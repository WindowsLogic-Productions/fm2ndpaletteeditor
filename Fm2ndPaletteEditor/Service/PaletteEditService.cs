using ColorMine.ColorSpaces;
using ColorMine.ColorSpaces.Comparisons;
using ImageProcessor;
using Sc.Util.Rendering;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;

namespace Fm2ndPaletteEditor.Service
{
    public class PaletteEditService
    {

        [DllImport("shlwapi.dll")]
        public static extern int ColorHLSToRGB(int H, int L, int S);

        public ColorChangeChain Chain { get; set; } = new ColorChangeChain();
        public Player Player { get; private set; }

        internal void Open(string fileName)
        {
            Player = new Player(fileName);
        }

        public Color ApplyColorChange(Color color, ColorChange change)
        {
            var multiplier = change.ColorFilter.Enabled ? calculateMultiplier(color, change.ColorFilter) : 1;

            var result = color;
            if (color.ToArgb() != Color.Black.ToArgb())
            {
                result = Color.FromArgb(color.A,
                    changeValueToInt(color.R, change.R, multiplier),
                    changeValueToInt(color.G, change.G, multiplier),
                    changeValueToInt(color.B, change.B, multiplier)
                );

                var hsl = SimpleColorTransforms.RgBtoHsl(result);
                result = SimpleColorTransforms.HsLtoRgb(
                       changeValue(hsl[0], (float)change.H * (double)(360 / 255), multiplier),
                       changeValue(hsl[1], (float)change.S / 255, multiplier),
                       changeValue(hsl[2], (float)change.L / 255, multiplier)
                    );

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
            return result;
        }

        private double calculateMultiplier(Color color, ColorFilter filter)
        {
            var closiness = 1 - distance(filter.Color, color);
            var result = Math.Pow(closiness, (1 - filter.Fuzziness) * 100);
            return result;
        }

        public Color[] TransformPalette(Color[] palette)
        {
            var result = (Color[])palette.Clone();
            TransformPalette(result, palette);
            return result;
        }

        private double changeValue(double value, double change, double multiplier)
        {
            return minMax(value + (change * multiplier));
        }
        private int changeValueToInt(double value, double change, double multiplier)
        {
            return (int)Math.Round(changeValue(value, change, multiplier));
        }

        double distance(Color c1, Color c2)
        {
            var a = new Rgb { R = c1.R, G = c1.G, B = c1.B };
            var b = new Rgb { R = c2.R, G = c2.G, B = c2.B };

            var deltaE = a.Compare(b, new Cie1976Comparison());
            return deltaE / 255;
        }

        internal void TransformPalette(Color[] targetPalette, Color[] originalPalette)
        {
            for (int i = 0; i < originalPalette.Length; i++)
            {
                foreach (var colorChange in Chain.ColorChanges)
                {
                    targetPalette[i] = this.ApplyColorChange(originalPalette[i], colorChange);
                }
            }
        }

        private int minMax(int v, int max = 255)
        {
            return Math.Max(Math.Min(v, max), 0);
        }

        private double minMax(double v, double max = 255)
        {
            return Math.Max(Math.Min(v, max), 0);
        }

        internal void Save()
        {
            throw new NotImplementedException();
        }
    }
}
