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
            }
            if (Service.Player != null)
            {
                _palette = Service.TransformPalette(Service.Player.Palettes[_currentPalette]);
            }
            this.Refresh();
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
                if (color.A == 255)
                {
                    using (SolidBrush brush = new SolidBrush(color))
                        e.Graphics.FillRectangle(brush, e.CellBounds);
                }
                else
                {
                    using (SolidBrush brush = new SolidBrush(Color.Black))
                    {
                        var x = e.CellBounds.Left + (e.CellBounds.Width / 2);
                        var y = e.CellBounds.Top + (e.CellBounds.Height / 2);
                        var rectangle = new Rectangle(new Point(x - 1, y - 1), new Size(2, 2));

                        e.Graphics.FillEllipse(brush, rectangle);
                    }
                }
            }
        }

        private static int cellToPaletteIdx(int row, int column)
        {
            return (row * 16) + column;
        }

        object _inDoubleClick;
        DateTime _lastClick;
        TimeSpan _doubleClickMaxTime = TimeSpan.FromMilliseconds(SystemInformation.DoubleClickTime);
        //private void tb_MouseDown(object sender, MouseEventArgs e)
        //{
        //    if (_inDoubleClick == sender)
        //    {
        //        _inDoubleClick = false;

        //        TimeSpan length = DateTime.Now - _lastClick;

        //        // If double click is valid, respond
        //        if (length < _doubleClickMaxTime)
        //        {
        //            _doubleClickAction();
        //        }

        //        return;
        //    }

        //    _lastClick = DateTime.Now;
        //    _inDoubleClick = sender;
        //}

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
                    dialog.Filter = "Player|*.player";
                    dialog.Title = "Open Player";
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (var dialog = new SaveFileDialog())
            {
                dialog.Filter = "Player|*.player";
                dialog.Title = "Save Player";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        var palettes = Service.TransformPalettes(Service.Player.Palettes);
                        Service.Player.SavePalettes(dialog.FileName, palettes);
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
            if (Service.Player != null)
            {
                var cellPos = GetRowColIndex(
                    tableLayoutPanel1,
                    tableLayoutPanel1.PointToClient(Cursor.Position));
                if (cellPos.HasValue)
                {
                    var idx = cellToPaletteIdx(cellPos.Value.Y, cellPos.Value.X);
                    CurrentColorChange.ColorFilter.Color = Service.Player.Palettes[0][idx];
                    applyTransformation();
                }
            }
        }

        private void tbColorFilterFuzziness_Scroll(object sender, EventArgs e)
        {
            CurrentColorChange.ColorFilter.Fuzziness = tbColorFilterFuzziness.Value;
            CurrentColorChange.ColorFilter.M = tbM.Value;
            applyTransformation();
        }

        private void cbColorFilterEnabled_CheckedChanged(object sender, EventArgs e)
        {
            CurrentColorChange.ColorFilter.Enabled = cbColorFilterEnabled.Checked;
            applyTransformation();
        }

        private void btnAddColorChange_Click(object sender, EventArgs e)
        {
            this.Service.Chain.ColorChanges.Add(new ColorChange());
            lstChain.DataSource = Service.Chain.ColorChanges;
            applyTransformation();
        }

        private void lstChain_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbRed.Value = CurrentColorChange.R;
            tbGreen.Value = CurrentColorChange.G;
            tbBlue.Value = CurrentColorChange.B;
            tbH.Value = CurrentColorChange.H;
            tbL.Value = CurrentColorChange.L;
            tbS.Value = CurrentColorChange.S;

            cbColorFilterEnabled.Checked = CurrentColorChange.ColorFilter.Enabled;
            tbColorFilterFuzziness.Value = (int)CurrentColorChange.ColorFilter.Fuzziness;
            cbColorChangeEnabled.Checked = CurrentColorChange.Enabled;
            applyTransformation();
        }

        private void cbColorChangeEnabled_CheckedChanged(object sender, EventArgs e)
        {
            CurrentColorChange.Enabled = cbColorChangeEnabled.Checked;
            applyTransformation();
        }

        private void btnColorChangeReset_Click(object sender, EventArgs e)
        {            
            tbH.Value = 0;
            tbS.Value = 0;
            tbL.Value = 0;
            tbRed.Value = 0;
            tbGreen.Value = 0;
            tbBlue.Value = 0;
            tb_Scroll(sender, e);
        }
    }
}
