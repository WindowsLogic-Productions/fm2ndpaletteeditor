using Fm2ndPaletteEditor.Service;
using ImageProcessor.Imaging.Quantizers;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Windows.Forms;

namespace Fm2ndPaletteEditor
{
    public partial class frmMain : Form
    {
        public PaletteEditService Service { get; set; } = new PaletteEditService();

        public Bitmap _bitmap { get; set; }
        public Color[] _bitmapOriginalPalette { get; set; }
        public Color[] _palette { get; set; }
        public ColorChange CurrentColorChange
        {
            get => (ColorChange)lstChain.SelectedItem;
        }
        int _currentPalette;

        public frmMain()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            SetDoubleBuffered(this.tableLayoutPanel1);

            lstChain.DataSource = Service.Chain.ColorChanges;
            lstChain.DisplayMember = "Idx";
            lstChain.SelectedItem = Service.Chain.ColorChanges[0];
        }

        #region .. Double Buffered function ..
        public static void SetDoubleBuffered(System.Windows.Forms.Control c)
        {
            if (System.Windows.Forms.SystemInformation.TerminalServerSession)
                return;
            System.Reflection.PropertyInfo aProp = typeof(System.Windows.Forms.Control).GetProperty("DoubleBuffered", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            aProp.SetValue(c, true, null);
        }

        #endregion


        #region .. code for Flucuring ..

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

        #endregion

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
            // set alpha to transparent
            _bitmap.Palette.Entries[transpIdx] = Color.FromArgb(255, 0, 0, 0);
            _bitmap.Palette = _bitmap.Palette;

            _bitmapOriginalPalette = (Color[])_bitmap.Palette.Entries.Clone();
            applyTransformation();
        }

        private void applyTransformation()
        {
            if (_bitmap != null)
            {
                ColorPalette pal = _bitmap.Palette;
                var entries = pal.Entries;
                Service.TransformPalette(entries, _bitmapOriginalPalette);
                _bitmap.Palette = pal;
                this.pbBitmap.Refresh();
            }
            if (Service.Player != null)
            {
                _palette = Service.TransformPalette(Service.Player.Palettes[_currentPalette]);
                tableLayoutPanel1.Refresh();
            }
        }


        private Bitmap convertToIndexed(Bitmap bmp)
        {
            OctreeQuantizer quantizer = new OctreeQuantizer(255, 8);

            using (Bitmap quantized = quantizer.Quantize(bmp))
            {
                return quantized.Clone(new Rectangle(0, 0, bmp.Width, bmp.Height), PixelFormat.Format8bppIndexed);
            }
        }

        private void tableLayoutPanel1_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            int idx = cellToPaletteIdx(e.Row, e.Column);
            if (_palette != null)
            {
                var color = idx < _palette.Count() ? _palette[idx] : Color.Transparent;
                using (SolidBrush brush = new SolidBrush(color))
                    e.Graphics.FillRectangle(brush, e.CellBounds);
            }
        }

        private static int cellToPaletteIdx(int row, int column)
        {
            return (row * 16) + column;
        }

        private void tb_Scroll(object sender, EventArgs e)
        {
            CurrentColorChange.R = tbRed.Value;
            CurrentColorChange.G = tbGreen.Value;
            CurrentColorChange.B = tbBlue.Value;
            CurrentColorChange.H = tbH.Value;
            CurrentColorChange.L = tbL.Value;
            CurrentColorChange.S = tbS.Value;
            applyTransformation();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            using (var dialog = new OpenFileDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        Service.Open(dialog.FileName);
                        applyTransformation();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}");
                    }
                }
            }
        }

        #region palette radio buttons
        private void rbPalette1_CheckedChanged(object sender, EventArgs e)
        {
            _currentPalette = 0;
            applyTransformation();
        }

        private void rbPalette2_CheckedChanged(object sender, EventArgs e)
        {
            _currentPalette = 1;
            applyTransformation();
        }

        private void rbPalette3_CheckedChanged(object sender, EventArgs e)
        {
            _currentPalette = 2;
            applyTransformation();
        }

        private void rbPalette4_CheckedChanged(object sender, EventArgs e)
        {
            _currentPalette = 3;
            applyTransformation();
        }

        private void rbPalette5_CheckedChanged(object sender, EventArgs e)
        {
            _currentPalette = 4;
            applyTransformation();
        }

        private void rbPalette6_CheckedChanged(object sender, EventArgs e)
        {
            _currentPalette = 5;
            applyTransformation();
        }

        private void rbPalette7_CheckedChanged(object sender, EventArgs e)
        {
            _currentPalette = 6;
            applyTransformation();
        }

        private void rbPalette8_CheckedChanged(object sender, EventArgs e)
        {
            _currentPalette = 7;
            applyTransformation();
        }

        private void pnlFilterColor_Paint(object sender, PaintEventArgs e)
        {
            using (SolidBrush brush = new SolidBrush(CurrentColorChange.ColorFilter.Color))
                e.Graphics.FillRectangle(brush, e.ClipRectangle);
        }
        #endregion

        Point? GetRowColIndex(TableLayoutPanel tlp, Point point)
        {
            if (point.X > tlp.Width || point.Y > tlp.Height)
                return null;

            int w = tlp.Width;
            int h = tlp.Height;
            int[] widths = tlp.GetColumnWidths();

            int i;
            for (i = widths.Length - 1; i >= 0 && point.X < w; i--)
                w -= widths[i];
            int col = i + 1;

            int[] heights = tlp.GetRowHeights();
            for (i = heights.Length - 1; i >= 0 && point.Y < h; i--)
                h -= heights[i];

            int row = i + 1;

            return new Point(col, row);
        }

        private void tableLayoutPanel1_Click(object sender, EventArgs e)
        {
            var cellPos = GetRowColIndex(
                tableLayoutPanel1,
                tableLayoutPanel1.PointToClient(Cursor.Position));
            if (cellPos.HasValue)
            {
                var idx = cellToPaletteIdx(cellPos.Value.Y, cellPos.Value.X);
                CurrentColorChange.ColorFilter.Color = Service.Player.Palettes[0][idx];
                applyTransformation();
                pnlFilterColor.Refresh();
            }
        }

        private void tbColorFilterFuzziness_Scroll(object sender, EventArgs e)
        {
            applyTransformation();
        }

        private void cbColorFilterEnabled_CheckedChanged(object sender, EventArgs e)
        {
            CurrentColorChange.ColorFilter.Enabled = cbColorFilterEnabled.Checked;
        }

        private void btnAddColorChange_Click(object sender, EventArgs e)
        {
            this.Service.Chain.ColorChanges.Add(new ColorChange());
            lstChain.DataSource = Service.Chain.ColorChanges;
            applyTransformation();
        }
    }
}
