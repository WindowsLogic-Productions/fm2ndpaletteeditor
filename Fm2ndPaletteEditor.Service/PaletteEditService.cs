using ColorMine.ColorSpaces;
using ColorMine.ColorSpaces.Comparisons;
using Sc.Util.Rendering;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Linq;

namespace Fm2ndPaletteEditor.Service
{
    public class PaletteEditService
    {

        [DllImport("shlwapi.dll")]
        public static extern int ColorHLSToRGB(int H, int L, int S);

        public ColorChangeChain Chain { get; set; } = new ColorChangeChain();
        public Player Player { get; private set; }

        public void Open(string fileName)
        {
            Player = new Player(fileName);
        }

        public Color ApplyColorChange(Color color, ColorChange change)
        {
            var result = color;
            if (change.Enabled && color.A == 255)
            {
                var multiplier = change.ColorFilter.Enabled ? calculateMultiplier(color, change.ColorFilter) : 1;

                // black i meant to be transparent
                if (color.ToArgb() != Color.Black.ToArgb())
                {

                    result = sumColors(color, change, multiplier);
                    //result = Blend(color, change, multiplier);

                    result = sumHsl(result, change, multiplier);

                    //var hsb = SimpleColorTransforms.RgBtoHsb(result);
                    //result = SimpleColorTransforms.HsBtoRgb(
                    //       hsb[0] + tbH.Value,
                    //       hsb[1] + ((float)tbS.Value / 255),
                    //       hsb[2] + ((float)tbL.Value / 255)
                    //    );


                    //var hls = ColorHLSToRGB(
                    //    minMax((int)Math.Round(result.GetHue() / 360 * 240) + tbH.Value, 240),
                    //    minMax((int)Math.Round(result.GetBrightness() * 240) + tbL.Value, 240),
                    //    minMax((int)Math.Round(result.GetSaturation() * 240) + tbS.Value, 240)
                    //);

                    //result = ColorTranslator.FromWin32(hls);
                }

            }
            return result;
        }

        private Color BlendHsl(Color color1, ColorChange color2, double multiplier)
        {
            var hsl = SimpleColorTransforms.RgBtoHsl(color1);
            var result = SimpleColorTransforms.HsLtoRgb(
                BlendColorComponent(hsl[0], (float)color2.H, multiplier),
                BlendColorComponent(hsl[1], (float)color2.S, multiplier),
                BlendColorComponent(hsl[2], (float)color2.L, multiplier)
            );
            return result;
        }

        private double calculateMultiplier(Color color, ColorFilter filter)
        {
            // y=1-m(x-f)
            var d = distance(filter.Color, color);
            var f = filter.Fuzziness / 1000;
            var m = 1000 - (filter.M / 10);

            var result = 1 - (m * (d - f));
            result = minMax(result, 1);
            return result;
        }

        public Color[] CloneAndApplyChainColorChanges(Color[] palette)
        {
            var result = (Color[])palette.Clone();
            ApplyChainColorChanges(result, palette);
            return result;
        }

        #region color modification
        private Color sumColors(Color color, ColorChange change, double multiplier)
        {
            return Color.FromArgb(color.A,
                                    changeValueToInt(color.R, change.R, multiplier),
                                    changeValueToInt(color.G, change.G, multiplier),
                                    changeValueToInt(color.B, change.B, multiplier)
                                );
        }
        private Color sumHsl(Color color1, ColorChange color2, double multiplier)
        {
            var hsl = SimpleColorTransforms.RgBtoHsl(color1);
            var result = SimpleColorTransforms.HsLtoRgb(
                changeValue(hsl[0], (float)color2.H, multiplier, 360, true),
                changeValue(hsl[1], (float)color2.S / 256, multiplier, 255),
                changeValue(hsl[2], (float)color2.L / 256, multiplier, 255)
            );
            return result;
        }

        //result = SimpleColorTransforms.HsBtoRgb(
        //       hsb[0] + tbH.Value,
        //       hsb[1] + ((float)tbS.Value / 255),
        //       hsb[2] + ((float)tbL.Value / 255)
        //    );


        //var hls = ColorHLSToRGB(
        //    minMax((int)Math.Round(result.GetHue() / 360 * 240) + tbH.Value, 240),
        //    minMax((int)Math.Round(result.GetBrightness() * 240) + tbL.Value, 240),
        //    minMax((int)Math.Round(result.GetSaturation() * 240) + tbS.Value, 240)
        //);

        //result = ColorTranslator.FromWin32(hls);


        /// <summary>Blends the specified colors together.</summary>
        /// <param name="color">Color to blend onto the background color.</param>
        /// <param name="backColor">Color to blend the other color onto.</param>
        /// <param name="amount">How much of <paramref name="color"/> to keep,
        /// “on top of” <paramref name="backColor"/>.</param>
        /// <returns>The blended colors.</returns>
        public Color Blend(Color color, ColorChange backColor, double amount)
        {
            var r = (int)BlendColorComponent(color.R, backColor.R, amount);
            var g = (int)BlendColorComponent(color.G, backColor.G, amount);
            var b = (int)BlendColorComponent(color.B, backColor.B, amount);
            return Color.FromArgb(r, g, b);
        }

        private double BlendColorComponent(double a, double b, double amount)
        {
            return minMax((a * amount) + b * (1 - amount));
        }

        private double changeValue(double value, double change, double multiplier, double max, bool warp = false)
        {
            var result = changeValue(value, change, multiplier);
            if (warp)
                return (result + max) % max;
            else
                return minMax(result, max);
        }

        private double changeValue(double value, double change, double multiplier)
        {
            return value + (change * multiplier);
        }

        private int changeValueToInt(double value, double change, double multiplier)
        {
            return (int)Math.Round(minMax(changeValue(value, change, multiplier)));
        }

        #endregion

        double distance(Color c1, Color c2)
        {
            var a = new Rgb { R = c1.R, G = c1.G, B = c1.B };
            var b = new Rgb { R = c2.R, G = c2.G, B = c2.B };

            var deltaE = a.Compare(b, new Cie1976Comparison());
            return deltaE / 255;
        }

        public void ApplyChainColorChanges(Color[] targetPalette, Color[] originalPalette)
        {
            for (int i = 0; i < originalPalette.Length; i++)
            {
                var newColor = originalPalette[i];
                foreach (var colorChange in Chain.ColorChanges)
                {
                    newColor = this.ApplyColorChange(newColor, colorChange);
                }
                targetPalette[i] = newColor;
            }
        }

        private int minMax(int v, int max = 255)
        {
            return Math.Max(Math.Min(v, max), 0);
        }

        private double minMax(double v, double max = 255, double min = 0)
        {
            return Math.Max(Math.Min(v, max), min);
        }

        internal void Save()
        {
            throw new NotImplementedException();
        }
    }
}
