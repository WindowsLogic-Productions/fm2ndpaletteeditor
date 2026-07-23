using ColorMine.ColorSpaces;
using Fm2ndPaletteEditor.Service;
using ImageProcessor.Imaging.Quantizers;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Fm2ndPaletteEditor
{
    public partial class frmMain : Form
    {
        private PaletteEditService _service { get; set; } = new PaletteEditService();
        private Color[]? _bitmapOriginalPalette { get; set; }
        private Color[]? _palette { get; set; }
        public ColorChange CurrentColorChange
        {
            get => (ColorChange)lstChain.SelectedItem;
        }

        int _currentPalette;

        public frmMain()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            SetDoubleBuffered(this.tlpResultPalette);

            lstChain.DataSource = _service.Chain.ColorChanges;
            lstChain.DisplayMember = "Idx";
            lstChain.SelectedItem = _service.Chain.ColorChanges[0];

            cbTargetPalette.SelectedIndex = 0;
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

        private Bitmap loadBitmap(int i)
        {
            var bitmapStream = _service.Player.LoadImage(i, _currentPalette);
            var bitmap = (Bitmap)Bitmap.FromStream(bitmapStream);
            //_bitmap = convertToIndexed(bitmap);

            // set alpha to transparent
            var transpIdx = Array.FindIndex(bitmap.Palette.Entries, x => x.ToArgb() == Color.Black.ToArgb());
            bitmap.Palette.Entries[transpIdx] = Color.FromArgb(255, 0, 0, 0);
            bitmap.Palette = bitmap.Palette;

            _bitmapOriginalPalette = bitmap.Palette.Entries;
            pbBitmap.Image = bitmap;

            return bitmap;
        }

        private void applyTransformation()
        {
            if (_service.Player == null)
                return;

            loadBitmap((int)numCurrentImage.Value);
            var bitmap = (Bitmap)pbBitmap.Image!;

            ColorPalette pal = bitmap.Palette;// this returns a clone of the palette, so it's crucial to do it like this
            var entries = pal.Entries;
            _service.ApplyChainColorChanges(entries, _bitmapOriginalPalette!);
            bitmap.Palette = pal;
            pbBitmap.Refresh();

            _palette = _service.CloneAndApplyChainColorChanges(_service.Player.Palettes[_currentPalette].Colors);

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

        private void tlpSourcePalette_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            if (_service.Player == null)
                return;

            paintPaletteCell(e, _service.Player.Palettes[_currentPalette].Colors);
        }

        private void tlpResultPalette_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            paintPaletteCell(e, _palette);
        }

        private void paintPaletteCell(TableLayoutCellPaintEventArgs e, Color[] palette)
        {
            int idx = cellToPaletteIdx(e.Row, e.Column);
            if (palette != null)
            {
                var color = idx < palette.Count() ? palette[idx] : Color.Transparent;
                if (color.A == 255)
                {
                    using (SolidBrush brush = new SolidBrush(color))
                    {
                        e.Graphics.FillRectangle(brush, e.CellBounds);
                        if (CurrentColorChange.ColorFilter.PaletteIdx == idx)
                        {
                            var pen = color.GetBrightness() > 0.5 ? Pens.Black : Pens.White;
                            // fix cell bounds to map correcty to the cell
                            var rect = new Rectangle(e.CellBounds.Left, e.CellBounds.Top, e.CellBounds.Width - 1, e.CellBounds.Height - 1);
                            e.Graphics.DrawRectangle(pen, rect);
                        }
                    }
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
                dialog.Filter = "Player|*.player";
                dialog.Title = "Open Player";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    open(dialog.FileName);
                    numCurrentImage.Maximum = _service.Player.ImagesCount;
                    numCurrentImage_ValueChanged(numCurrentImage, new EventArgs());
                    lblLoadAdvice.Visible = false;
                }
            }
        }

        private void open(string fileName)
        {
            try
            {
                _service.Open(fileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var targetPalette = cbTargetPalette.SelectedIndex;

            var dialogResult = MessageBox.Show(
                $"The resulting palette will replace palette {targetPalette + 1} in {Path.GetFileName(_service.Player.FileName)}.{Environment.NewLine}" +
                $"A backup file will be created in the same folder, but please back up your files before continuing.",
                "Confirm Save",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2);

            if (dialogResult != DialogResult.Yes)
                return;

            try
            {
                _service.Player.SavePalette(_palette!, targetPalette);
                applyTransformation();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        #region palette radio buttons
        private void rbPalette1_CheckedChanged(object sender, EventArgs e)
        {
            if (!rbPalette1.Checked) return;

            _currentPalette = 0;
            applyTransformation();
        }

        private void rbPalette2_CheckedChanged(object sender, EventArgs e)
        {
            if (!rbPalette2.Checked) return;

            _currentPalette = 1;
            applyTransformation();
        }

        private void rbPalette3_CheckedChanged(object sender, EventArgs e)
        {
            if (!rbPalette3.Checked) return;

            _currentPalette = 2;
            applyTransformation();
        }

        private void rbPalette4_CheckedChanged(object sender, EventArgs e)
        {
            if (!rbPalette4.Checked) return;

            _currentPalette = 3;
            applyTransformation();
        }

        private void rbPalette5_CheckedChanged(object sender, EventArgs e)
        {
            if (!rbPalette5.Checked) return;

            _currentPalette = 4;
            applyTransformation();
        }

        private void rbPalette6_CheckedChanged(object sender, EventArgs e)
        {
            if (!rbPalette6.Checked) return;

            _currentPalette = 5;
            applyTransformation();
        }

        private void rbPalette7_CheckedChanged(object sender, EventArgs e)
        {
            if (!rbPalette7.Checked) return;

            _currentPalette = 6;
            applyTransformation();
        }

        private void rbPalette8_CheckedChanged(object sender, EventArgs e)
        {
            if (!rbPalette8.Checked) return;

            _currentPalette = 7;
            applyTransformation();
        }

        private void pnlFilterColor_Paint(object sender, PaintEventArgs e)
        {
            using (SolidBrush brush = new SolidBrush(CurrentColorChange.ColorFilter.Color))
                e.Graphics.FillRectangle(brush, e.ClipRectangle);

            var color = CurrentColorChange.ColorFilter.Color;
            lblColorHex.Text = $"#{color.R.ToString("X2")}{color.G.ToString("X2")}{color.B.ToString("X2")}";
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

        private void tlpSourcePalette_Click(object sender, EventArgs e)
        {
            if (_service.Player == null)
                return;
            selectCurrentColorChangeColor(tlpSourcePalette);
        }

        private void tlpResultPalette_MouseClick(object sender, MouseEventArgs e)
        {
            if (_service.Player == null)
                return;
            selectCurrentColorChangeColor(tlpResultPalette);
        }

        private void selectCurrentColorChangeColor(TableLayoutPanel tlp)
        {
            var cellPos = GetRowColIndex(
                tlp,
                tlp.PointToClient(Cursor.Position));
            if (cellPos.HasValue)
            {
                var idx = cellToPaletteIdx(cellPos.Value.Y, cellPos.Value.X);
                selectCurrentColorChangeColor(idx);
            }
        }

        private void selectCurrentColorChangeColor(int idx)
        {
            CurrentColorChange.ColorFilter.Color = _service.Player.Palettes[_currentPalette].Colors[idx];
            CurrentColorChange.ColorFilter.PaletteIdx = idx;
            applyTransformation();
        }

        private void tbColorFilterRange_Scroll(object sender, EventArgs e)
        {
            CurrentColorChange.ColorFilter.Range = tbColorFilterRange.Value;
            CurrentColorChange.ColorFilter.M = tbM.Value;
            CurrentColorChange.ColorFilter.Comparison = Enum.Parse<ColorComparison>(cbComparisonMethod.Text);
            applyTransformation();
        }

        private void cbColorFilterEnabled_CheckedChanged(object sender, EventArgs e)
        {
            CurrentColorChange.ColorFilter.Enabled = cbColorFilterEnabled.Checked;
            applyTransformation();
        }

        private void btnAddColorChange_Click(object sender, EventArgs e)
        {
            this._service.Chain.ColorChanges.Add(new ColorChange());
            lstChain.DataSource = _service.Chain.ColorChanges;
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
            tbColorFilterRange.Value = (int)CurrentColorChange.ColorFilter.Range;
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

        private void pbBitmap_Click(object sender, EventArgs e)
        {
            if (_service.Player == null)
            {
                btnOpen_Click(sender, e);
                return;
            }

            MouseEventArgs me = (MouseEventArgs)e;
            var point = this.mapPbClickToBitmapPoint(me.Location);
            if (point.HasValue)
            {
                Bitmap bitmap = (Bitmap)pbBitmap.Image;
                int paletteIndex = bitmap.GetPixelPaletteIndex(point.Value.X, point.Value.Y);
                selectCurrentColorChangeColor(paletteIndex);
            }
        }

        private Point? mapPbClickToBitmapPoint(Point location)
        {
            int imgWidth = pbBitmap.Image!.Width;
            int imgHeight = pbBitmap.Image.Height;
            int pbWidth = pbBitmap.Width;
            int pbHeight = pbBitmap.Height;

            // Find the correct scale factor (the smallest between the two axes)
            float ratioX = (float)pbWidth / imgWidth;
            float ratioY = (float)pbHeight / imgHeight;
            float ratio = Math.Min(ratioX, ratioY);

            // Calculate the actual size of the image rendered on screen
            int targetWidth = (int)(imgWidth * ratio);
            int targetHeight = (int)(imgHeight * ratio);

            // Calculate the initial offset (where the image pixels start)
            int leftOffset = (pbWidth - targetWidth) / 2;
            int topOffset = (pbHeight - targetHeight) / 2;

            // Subtract the offset from the mouse click
            int relativeX = location.X - leftOffset;
            int relativeY = location.Y - topOffset;

            // Check if the click is within the actual image or on the empty bands
            if (relativeX >= 0 && relativeX < targetWidth && relativeY >= 0 && relativeY < targetHeight)
            {
                // Map finally to the original bitmap pixel
                int bitmapX = (int)(relativeX / ratio);
                int bitmapY = (int)(relativeY / ratio);

                // Safety for rounding
                bitmapX = Math.Clamp(bitmapX, 0, imgWidth - 1);
                bitmapY = Math.Clamp(bitmapY, 0, imgHeight - 1);

                return new Point(bitmapX, bitmapY);
            }
            return null;
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(lblColorHex.Text);
        }

        private void numCurrentImage_ValueChanged(object sender, EventArgs e)
        {
            if (_service.Player == null) return;

            loadBitmap((int)numCurrentImage.Value);
            lblIsPrivatePalette.Visible = _service.Player.IsPrivatePalette((int)numCurrentImage.Value);
            applyTransformation();
        }

        private void lblLoadAdvice_Click(object sender, EventArgs e)
        {
            pbBitmap_Click(sender, e);
        }
    }
}
