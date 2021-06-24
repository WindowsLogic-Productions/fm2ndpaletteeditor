using ImageProcessor.Imaging.Quantizers;
using Sc.Util.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fm2ndPaletteEditor
{
    public partial class frmMain : Form
    {
        public Bitmap _bitmap { get; set; }
        public Color[] _originalPalette { get; set; }
        public Color[] _palette { get; set; }

        public frmMain()
        {
            InitializeComponent();
        }

        [DllImport("shlwapi.dll")]
        public static extern int ColorHLSToRGB(int H, int L, int S);

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            using (var dialog = new OpenFileDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        loadImage(dialog.FileName);

                        lblImageHint.Visible = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}");
                    }
                }
            }
        }

        private void loadImage(string filename)
        {
            var image = Image.FromFile(filename);
            var bitmap = new Bitmap(image);
            _bitmap = convertToIndexed(bitmap);
            pbBitmap.Image = _bitmap;
            var transpIdx = Array.FindIndex(_bitmap.Palette.Entries, x => x.ToArgb() == Color.Black.ToArgb());
            _bitmap.Palette.Entries[transpIdx] = Color.FromArgb(255, 0, 0, 0);
            _bitmap.Palette = _bitmap.Palette;

            _originalPalette = (Color[])_bitmap.Palette.Entries.Clone();
            applyTransformation();
        }

        private void applyTransformation()
        {
            if (_bitmap != null)
            {
                ColorPalette pal = _bitmap.Palette;
                for (int i = 0; i < _originalPalette.Length; i++)
                {
                    pal.Entries[i] = transformColor(_originalPalette[i]);

                }

                _bitmap.Palette = pal;
                _palette = _bitmap.Palette.Entries;
                this.pbBitmap.Refresh();
                tableLayoutPanel1.Refresh();
            }
        }

        private Color transformColor(Color color)
        {
            var result = color;
            if (color.ToArgb() != Color.Black.ToArgb())
            {
                result = Color.FromArgb(color.A,
                minMax(color.R + tbRed.Value),
                minMax(color.G + tbGreen.Value),
                minMax(color.B + tbBlue.Value)
            );
                var hsl = SimpleColorTransforms.RgBtoHsl(result);
                result = SimpleColorTransforms.HsLtoRgb(
                       hsl[0] + tbH.Value,
                       hsl[1] + ((float)tbS.Value / 255),
                       hsl[2] + ((float)tbL.Value / 255)
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

        private int minMax(int v, int max = 255)
        {
            return Math.Max(Math.Min(v, max), 0);
        }

        private double minMax(double v, double max = 255)
        {
            return Math.Max(Math.Min(v, max), 0);
        }

        unsafe private Bitmap convertToIndexed(Bitmap bmp)
        {
            OctreeQuantizer quantizer = new OctreeQuantizer(255, 8);

            using (Bitmap quantized = quantizer.Quantize(bmp))
            {
                return quantized.Clone(new Rectangle(0, 0, bmp.Width, bmp.Height), PixelFormat.Format8bppIndexed);
            }
        }

        private void tableLayoutPanel1_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            var idx = (e.Row * 16) + e.Column;
            if (_bitmap != null)
            {
                var color = idx < _palette.Count() ?
                    _bitmap.Palette.Entries[idx] :
                    Color.Transparent;
                using (SolidBrush brush = new SolidBrush(color))
                    e.Graphics.FillRectangle(brush, e.CellBounds);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var palette = new List<Color>();
            var tableTxt = Clipboard.GetText();
            using (var reader = new StringReader(tableTxt))
            {
                var idx = 0;
                var buffer = new Span<char>(new char[12]);
                var count = 0;
                while ((count = reader.Read(buffer)) > 0)
                {
                    var colorTxt = new String(buffer);
                    try
                    {
                        var color = parseFM2kColor(colorTxt);
                        var newColor = transformColor(color);
                        palette.Add(newColor);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error parsing color n.{idx} '{colorTxt}': {ex.Message}");
                        return;
                    }

                    idx++;
                }
            }

            using (var writer = new StringWriter())
            {
                foreach (var color in palette)
                {
                    var colorTxt = toFM2kColor(color);
                    writer.Write(colorTxt);
                }

                Clipboard.SetText(writer.ToString());
            }
        }

        private object toFM2kColor(Color color)
        {
            var r = (int)Math.Round((double)color.R / 8) * 8;
            var g = (int)Math.Round((double)color.G / 8) * 8;
            var b = (int)Math.Round((double)color.B / 8) * 8;
            return $"{b.ToString("X2")} {g.ToString("X2")} {r.ToString("X2")} 01 ";
        }


        private Color parseFM2kColor(string colorTxt)
        {
            var rgba = colorTxt.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            if (rgba.Count() != 4)
                throw new Exception("Wrong format");
            if (rgba[3] != "01")
                throw new Exception("No global palette");

            var b = int.Parse(rgba[0], NumberStyles.HexNumber);
            var g = int.Parse(rgba[1], NumberStyles.HexNumber);
            var r = int.Parse(rgba[2], NumberStyles.HexNumber);

            var color = Color.FromArgb(r, g, b);
            return color;
        }

        int smallChangeValue = 8;
        private void tb_Scroll(object sender, EventArgs e)
        {
            applyTransformation();
        }
    }
}
