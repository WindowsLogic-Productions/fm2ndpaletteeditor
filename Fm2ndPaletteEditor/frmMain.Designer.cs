namespace Fm2ndPaletteEditor
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pbBitmap = new PictureBox();
            tlpResultPalette = new TableLayoutPanel();
            tbRed = new TrackBar();
            label1 = new Label();
            tbGreen = new TrackBar();
            tbBlue = new TrackBar();
            label2 = new Label();
            label3 = new Label();
            tbH = new TrackBar();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            tbL = new TrackBar();
            tbS = new TrackBar();
            groupBox1 = new GroupBox();
            btnColorChangeReset = new Button();
            cbColorChangeEnabled = new CheckBox();
            rbPalette1 = new RadioButton();
            rbPalette2 = new RadioButton();
            rbPalette3 = new RadioButton();
            rbPalette4 = new RadioButton();
            rbPalette5 = new RadioButton();
            rbPalette6 = new RadioButton();
            rbPalette7 = new RadioButton();
            rbPalette8 = new RadioButton();
            btnOpen = new Button();
            gbColorFilter = new GroupBox();
            cbComparisonMethod = new ComboBox();
            label9 = new Label();
            btnCopy = new Button();
            lblColorHex = new Label();
            lblColor = new Label();
            cbColorFilterEnabled = new CheckBox();
            lblBlend = new Label();
            pnlFilterColor = new Panel();
            tbColorFilterRange = new TrackBar();
            tbM = new TrackBar();
            lblColorFilterRange = new Label();
            lstChain = new ListBox();
            btnSave = new Button();
            lblModifications = new Label();
            lblSourcePalette = new Label();
            tlpSourcePalette = new TableLayoutPanel();
            label7 = new Label();
            cbTargetPalette = new ComboBox();
            numCurrentImage = new NumericUpDown();
            lblIsPrivatePalette = new Label();
            label8 = new Label();
            toolTip1 = new ToolTip(components);
            lblLoadAdvice = new Label();
            ((System.ComponentModel.ISupportInitialize)pbBitmap).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbRed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbGreen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbBlue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbH).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbL).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbS).BeginInit();
            groupBox1.SuspendLayout();
            gbColorFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbColorFilterRange).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbM).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCurrentImage).BeginInit();
            SuspendLayout();
            // 
            // pbBitmap
            // 
            pbBitmap.BackgroundImageLayout = ImageLayout.Zoom;
            pbBitmap.BorderStyle = BorderStyle.FixedSingle;
            pbBitmap.Location = new Point(13, 37);
            pbBitmap.Margin = new Padding(4, 5, 4, 5);
            pbBitmap.Name = "pbBitmap";
            pbBitmap.Size = new Size(389, 384);
            pbBitmap.SizeMode = PictureBoxSizeMode.Zoom;
            pbBitmap.TabIndex = 0;
            pbBitmap.TabStop = false;
            pbBitmap.Click += pbBitmap_Click;
            // 
            // tlpResultPalette
            // 
            tlpResultPalette.ColumnCount = 16;
            tlpResultPalette.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 23F));
            tlpResultPalette.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 23F));
            tlpResultPalette.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 23F));
            tlpResultPalette.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 23F));
            tlpResultPalette.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 23F));
            tlpResultPalette.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 23F));
            tlpResultPalette.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 23F));
            tlpResultPalette.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 23F));
            tlpResultPalette.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 23F));
            tlpResultPalette.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 23F));
            tlpResultPalette.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 23F));
            tlpResultPalette.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 23F));
            tlpResultPalette.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 23F));
            tlpResultPalette.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 23F));
            tlpResultPalette.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 23F));
            tlpResultPalette.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 25F));
            tlpResultPalette.Location = new Point(876, 541);
            tlpResultPalette.Margin = new Padding(4, 5, 4, 5);
            tlpResultPalette.Name = "tlpResultPalette";
            tlpResultPalette.RowCount = 16;
            tlpResultPalette.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tlpResultPalette.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tlpResultPalette.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tlpResultPalette.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tlpResultPalette.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tlpResultPalette.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tlpResultPalette.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tlpResultPalette.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tlpResultPalette.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tlpResultPalette.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tlpResultPalette.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tlpResultPalette.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tlpResultPalette.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tlpResultPalette.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tlpResultPalette.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tlpResultPalette.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tlpResultPalette.Size = new Size(368, 416);
            tlpResultPalette.TabIndex = 1;
            tlpResultPalette.CellPaint += tlpResultPalette_CellPaint;
            tlpResultPalette.MouseClick += tlpResultPalette_MouseClick;
            // 
            // tbRed
            // 
            tbRed.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbRed.LargeChange = 32;
            tbRed.Location = new Point(30, 65);
            tbRed.Margin = new Padding(4, 5, 4, 5);
            tbRed.Maximum = 256;
            tbRed.Minimum = -256;
            tbRed.Name = "tbRed";
            tbRed.Size = new Size(418, 56);
            tbRed.SmallChange = 8;
            tbRed.TabIndex = 3;
            tbRed.TickFrequency = 8;
            tbRed.Scroll += tb_Scroll;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 65);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(18, 20);
            label1.TabIndex = 4;
            label1.Text = "R";
            // 
            // tbGreen
            // 
            tbGreen.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbGreen.LargeChange = 32;
            tbGreen.Location = new Point(30, 134);
            tbGreen.Margin = new Padding(4, 5, 4, 5);
            tbGreen.Maximum = 256;
            tbGreen.Minimum = -256;
            tbGreen.Name = "tbGreen";
            tbGreen.Size = new Size(418, 56);
            tbGreen.SmallChange = 8;
            tbGreen.TabIndex = 3;
            tbGreen.TickFrequency = 8;
            tbGreen.Scroll += tb_Scroll;
            // 
            // tbBlue
            // 
            tbBlue.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbBlue.LargeChange = 32;
            tbBlue.Location = new Point(32, 202);
            tbBlue.Margin = new Padding(4, 5, 4, 5);
            tbBlue.Maximum = 256;
            tbBlue.Minimum = -256;
            tbBlue.Name = "tbBlue";
            tbBlue.Size = new Size(417, 56);
            tbBlue.SmallChange = 8;
            tbBlue.TabIndex = 3;
            tbBlue.TickFrequency = 8;
            tbBlue.Scroll += tb_Scroll;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 134);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(19, 20);
            label2.TabIndex = 4;
            label2.Text = "G";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 202);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(18, 20);
            label3.TabIndex = 4;
            label3.Text = "B";
            // 
            // tbH
            // 
            tbH.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbH.LargeChange = 32;
            tbH.Location = new Point(32, 269);
            tbH.Margin = new Padding(4, 5, 4, 5);
            tbH.Maximum = 180;
            tbH.Minimum = -180;
            tbH.Name = "tbH";
            tbH.Size = new Size(418, 56);
            tbH.SmallChange = 8;
            tbH.TabIndex = 3;
            tbH.TickFrequency = 8;
            tbH.Scroll += tb_Scroll;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 269);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(20, 20);
            label4.TabIndex = 4;
            label4.Text = "H";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(8, 337);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(16, 20);
            label5.TabIndex = 4;
            label5.Text = "L";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(8, 405);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(17, 20);
            label6.TabIndex = 4;
            label6.Text = "S";
            // 
            // tbL
            // 
            tbL.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbL.LargeChange = 32;
            tbL.Location = new Point(32, 337);
            tbL.Margin = new Padding(4, 5, 4, 5);
            tbL.Maximum = 256;
            tbL.Minimum = -256;
            tbL.Name = "tbL";
            tbL.Size = new Size(418, 56);
            tbL.SmallChange = 8;
            tbL.TabIndex = 3;
            tbL.TickFrequency = 8;
            tbL.Scroll += tb_Scroll;
            // 
            // tbS
            // 
            tbS.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbS.LargeChange = 32;
            tbS.Location = new Point(34, 405);
            tbS.Margin = new Padding(4, 5, 4, 5);
            tbS.Maximum = 256;
            tbS.Minimum = -256;
            tbS.Name = "tbS";
            tbS.Size = new Size(417, 56);
            tbS.SmallChange = 8;
            tbS.TabIndex = 3;
            tbS.TickFrequency = 8;
            tbS.Scroll += tb_Scroll;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnColorChangeReset);
            groupBox1.Controls.Add(cbColorChangeEnabled);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(tbRed);
            groupBox1.Controls.Add(tbH);
            groupBox1.Controls.Add(tbS);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(tbBlue);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(tbL);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(tbGreen);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label6);
            groupBox1.Location = new Point(409, 431);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(457, 464);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Color Change";
            // 
            // btnColorChangeReset
            // 
            btnColorChangeReset.Location = new Point(351, 26);
            btnColorChangeReset.Margin = new Padding(4, 5, 4, 5);
            btnColorChangeReset.Name = "btnColorChangeReset";
            btnColorChangeReset.Size = new Size(100, 29);
            btnColorChangeReset.TabIndex = 6;
            btnColorChangeReset.Text = "Reset";
            btnColorChangeReset.UseVisualStyleBackColor = true;
            btnColorChangeReset.Click += btnColorChangeReset_Click;
            // 
            // cbColorChangeEnabled
            // 
            cbColorChangeEnabled.AutoSize = true;
            cbColorChangeEnabled.Location = new Point(9, 29);
            cbColorChangeEnabled.Margin = new Padding(4, 5, 4, 5);
            cbColorChangeEnabled.Name = "cbColorChangeEnabled";
            cbColorChangeEnabled.Size = new Size(85, 24);
            cbColorChangeEnabled.TabIndex = 5;
            cbColorChangeEnabled.Text = "Enabled";
            cbColorChangeEnabled.UseVisualStyleBackColor = true;
            cbColorChangeEnabled.CheckedChanged += cbColorChangeEnabled_CheckedChanged;
            // 
            // rbPalette1
            // 
            rbPalette1.AutoSize = true;
            rbPalette1.CheckAlign = ContentAlignment.TopCenter;
            rbPalette1.Checked = true;
            rbPalette1.Location = new Point(892, 22);
            rbPalette1.Margin = new Padding(4, 5, 4, 5);
            rbPalette1.Name = "rbPalette1";
            rbPalette1.Size = new Size(21, 40);
            rbPalette1.TabIndex = 10;
            rbPalette1.TabStop = true;
            rbPalette1.Text = "1";
            rbPalette1.UseVisualStyleBackColor = true;
            rbPalette1.CheckedChanged += rbPalette1_CheckedChanged;
            // 
            // rbPalette2
            // 
            rbPalette2.AutoSize = true;
            rbPalette2.CheckAlign = ContentAlignment.TopCenter;
            rbPalette2.Location = new Point(937, 22);
            rbPalette2.Margin = new Padding(4, 5, 4, 5);
            rbPalette2.Name = "rbPalette2";
            rbPalette2.Size = new Size(21, 40);
            rbPalette2.TabIndex = 10;
            rbPalette2.Text = "2";
            rbPalette2.UseVisualStyleBackColor = true;
            rbPalette2.CheckedChanged += rbPalette2_CheckedChanged;
            // 
            // rbPalette3
            // 
            rbPalette3.AutoSize = true;
            rbPalette3.CheckAlign = ContentAlignment.TopCenter;
            rbPalette3.Location = new Point(982, 22);
            rbPalette3.Margin = new Padding(4, 5, 4, 5);
            rbPalette3.Name = "rbPalette3";
            rbPalette3.Size = new Size(21, 40);
            rbPalette3.TabIndex = 10;
            rbPalette3.Text = "3";
            rbPalette3.UseVisualStyleBackColor = true;
            rbPalette3.CheckedChanged += rbPalette3_CheckedChanged;
            // 
            // rbPalette4
            // 
            rbPalette4.AutoSize = true;
            rbPalette4.CheckAlign = ContentAlignment.TopCenter;
            rbPalette4.Location = new Point(1029, 22);
            rbPalette4.Margin = new Padding(4, 5, 4, 5);
            rbPalette4.Name = "rbPalette4";
            rbPalette4.Size = new Size(21, 40);
            rbPalette4.TabIndex = 10;
            rbPalette4.Text = "4";
            rbPalette4.UseVisualStyleBackColor = true;
            rbPalette4.CheckedChanged += rbPalette4_CheckedChanged;
            // 
            // rbPalette5
            // 
            rbPalette5.AutoSize = true;
            rbPalette5.CheckAlign = ContentAlignment.TopCenter;
            rbPalette5.Location = new Point(1075, 22);
            rbPalette5.Margin = new Padding(4, 5, 4, 5);
            rbPalette5.Name = "rbPalette5";
            rbPalette5.Size = new Size(21, 40);
            rbPalette5.TabIndex = 10;
            rbPalette5.Text = "5";
            rbPalette5.UseVisualStyleBackColor = true;
            rbPalette5.CheckedChanged += rbPalette5_CheckedChanged;
            // 
            // rbPalette6
            // 
            rbPalette6.AutoSize = true;
            rbPalette6.CheckAlign = ContentAlignment.TopCenter;
            rbPalette6.Location = new Point(1119, 22);
            rbPalette6.Margin = new Padding(4, 5, 4, 5);
            rbPalette6.Name = "rbPalette6";
            rbPalette6.Size = new Size(21, 40);
            rbPalette6.TabIndex = 10;
            rbPalette6.Text = "6";
            rbPalette6.UseVisualStyleBackColor = true;
            rbPalette6.CheckedChanged += rbPalette6_CheckedChanged;
            // 
            // rbPalette7
            // 
            rbPalette7.AutoSize = true;
            rbPalette7.CheckAlign = ContentAlignment.TopCenter;
            rbPalette7.Location = new Point(1165, 22);
            rbPalette7.Margin = new Padding(4, 5, 4, 5);
            rbPalette7.Name = "rbPalette7";
            rbPalette7.Size = new Size(21, 40);
            rbPalette7.TabIndex = 10;
            rbPalette7.Text = "7";
            rbPalette7.UseVisualStyleBackColor = true;
            rbPalette7.CheckedChanged += rbPalette7_CheckedChanged;
            // 
            // rbPalette8
            // 
            rbPalette8.AutoSize = true;
            rbPalette8.CheckAlign = ContentAlignment.TopCenter;
            rbPalette8.Location = new Point(1212, 22);
            rbPalette8.Margin = new Padding(4, 5, 4, 5);
            rbPalette8.Name = "rbPalette8";
            rbPalette8.Size = new Size(21, 40);
            rbPalette8.TabIndex = 10;
            rbPalette8.Text = "8";
            rbPalette8.UseVisualStyleBackColor = true;
            rbPalette8.CheckedChanged += rbPalette8_CheckedChanged;
            // 
            // btnOpen
            // 
            btnOpen.Location = new Point(13, 911);
            btnOpen.Margin = new Padding(4, 5, 4, 5);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(116, 31);
            btnOpen.TabIndex = 11;
            btnOpen.Text = "Open Player File";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // gbColorFilter
            // 
            gbColorFilter.Controls.Add(cbComparisonMethod);
            gbColorFilter.Controls.Add(label9);
            gbColorFilter.Controls.Add(btnCopy);
            gbColorFilter.Controls.Add(lblColorHex);
            gbColorFilter.Controls.Add(lblColor);
            gbColorFilter.Controls.Add(cbColorFilterEnabled);
            gbColorFilter.Controls.Add(lblBlend);
            gbColorFilter.Controls.Add(pnlFilterColor);
            gbColorFilter.Controls.Add(tbColorFilterRange);
            gbColorFilter.Controls.Add(tbM);
            gbColorFilter.Controls.Add(lblColorFilterRange);
            gbColorFilter.Location = new Point(13, 471);
            gbColorFilter.Margin = new Padding(4, 5, 4, 5);
            gbColorFilter.Name = "gbColorFilter";
            gbColorFilter.Padding = new Padding(4, 5, 4, 5);
            gbColorFilter.Size = new Size(388, 430);
            gbColorFilter.TabIndex = 8;
            gbColorFilter.TabStop = false;
            gbColorFilter.Text = "Filter";
            // 
            // cbComparisonMethod
            // 
            cbComparisonMethod.FormattingEnabled = true;
            cbComparisonMethod.Items.AddRange(new object[] { "Cie1976", "Cie94", "CieDe2000", "Cmc" });
            cbComparisonMethod.Location = new Point(7, 185);
            cbComparisonMethod.Name = "cbComparisonMethod";
            cbComparisonMethod.Size = new Size(151, 28);
            cbComparisonMethod.TabIndex = 20;
            cbComparisonMethod.Text = "Cie1976";
            cbComparisonMethod.SelectedIndexChanged += tbColorFilterRange_Scroll;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(8, 162);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(145, 20);
            label9.TabIndex = 19;
            label9.Text = "Comparison method";
            // 
            // btnCopy
            // 
            btnCopy.Location = new Point(327, 67);
            btnCopy.Name = "btnCopy";
            btnCopy.Size = new Size(53, 28);
            btnCopy.TabIndex = 17;
            btnCopy.Text = "Copy";
            btnCopy.UseVisualStyleBackColor = true;
            btnCopy.Click += btnCopy_Click;
            // 
            // lblColorHex
            // 
            lblColorHex.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblColorHex.AutoSize = true;
            lblColorHex.Location = new Point(254, 75);
            lblColorHex.Margin = new Padding(4, 0, 4, 0);
            lblColorHex.Name = "lblColorHex";
            lblColorHex.Size = new Size(66, 20);
            lblColorHex.TabIndex = 14;
            lblColorHex.Text = "#000000";
            lblColorHex.TextAlign = ContentAlignment.TopRight;
            // 
            // lblColor
            // 
            lblColor.AutoSize = true;
            lblColor.Location = new Point(13, 75);
            lblColor.Margin = new Padding(4, 0, 4, 0);
            lblColor.Name = "lblColor";
            lblColor.Size = new Size(45, 20);
            lblColor.TabIndex = 13;
            lblColor.Text = "Color";
            // 
            // cbColorFilterEnabled
            // 
            cbColorFilterEnabled.AutoSize = true;
            cbColorFilterEnabled.Location = new Point(7, 26);
            cbColorFilterEnabled.Margin = new Padding(4, 5, 4, 5);
            cbColorFilterEnabled.Name = "cbColorFilterEnabled";
            cbColorFilterEnabled.Size = new Size(85, 24);
            cbColorFilterEnabled.TabIndex = 12;
            cbColorFilterEnabled.Text = "Enabled";
            cbColorFilterEnabled.UseVisualStyleBackColor = true;
            cbColorFilterEnabled.CheckedChanged += cbColorFilterEnabled_CheckedChanged;
            // 
            // lblBlend
            // 
            lblBlend.AutoSize = true;
            lblBlend.Location = new Point(8, 290);
            lblBlend.Margin = new Padding(4, 0, 4, 0);
            lblBlend.Name = "lblBlend";
            lblBlend.Size = new Size(47, 20);
            lblBlend.TabIndex = 13;
            lblBlend.Text = "Blend";
            // 
            // pnlFilterColor
            // 
            pnlFilterColor.Location = new Point(8, 100);
            pnlFilterColor.Margin = new Padding(4, 5, 4, 5);
            pnlFilterColor.Name = "pnlFilterColor";
            pnlFilterColor.Size = new Size(372, 55);
            pnlFilterColor.TabIndex = 5;
            pnlFilterColor.Paint += pnlFilterColor_Paint;
            // 
            // tbColorFilterRange
            // 
            tbColorFilterRange.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbColorFilterRange.LargeChange = 100;
            tbColorFilterRange.Location = new Point(3, 241);
            tbColorFilterRange.Margin = new Padding(4, 5, 4, 5);
            tbColorFilterRange.Maximum = 1000;
            tbColorFilterRange.Name = "tbColorFilterRange";
            tbColorFilterRange.Size = new Size(372, 56);
            tbColorFilterRange.SmallChange = 10;
            tbColorFilterRange.TabIndex = 3;
            tbColorFilterRange.TickFrequency = 8;
            tbColorFilterRange.Scroll += tbColorFilterRange_Scroll;
            // 
            // tbM
            // 
            tbM.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbM.LargeChange = 100;
            tbM.Location = new Point(3, 319);
            tbM.Margin = new Padding(4, 5, 4, 5);
            tbM.Maximum = 10000;
            tbM.Name = "tbM";
            tbM.Size = new Size(372, 56);
            tbM.SmallChange = 10;
            tbM.TabIndex = 3;
            tbM.TickFrequency = 8;
            tbM.Scroll += tbColorFilterRange_Scroll;
            // 
            // lblColorFilterRange
            // 
            lblColorFilterRange.AutoSize = true;
            lblColorFilterRange.Location = new Point(8, 216);
            lblColorFilterRange.Margin = new Padding(4, 0, 4, 0);
            lblColorFilterRange.Name = "lblColorFilterRange";
            lblColorFilterRange.Size = new Size(51, 20);
            lblColorFilterRange.TabIndex = 13;
            lblColorFilterRange.Text = "Range";
            // 
            // lstChain
            // 
            lstChain.DisplayMember = "Idx";
            lstChain.FormattingEnabled = true;
            lstChain.Location = new Point(409, 37);
            lstChain.Margin = new Padding(4, 5, 4, 5);
            lstChain.Name = "lstChain";
            lstChain.Size = new Size(460, 384);
            lstChain.TabIndex = 12;
            lstChain.SelectedIndexChanged += lstChain_SelectedIndexChanged;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(409, 905);
            btnSave.Margin = new Padding(4, 5, 4, 5);
            btnSave.Name = "btnSave";
            btnSave.RightToLeft = RightToLeft.Yes;
            btnSave.Size = new Size(116, 31);
            btnSave.TabIndex = 14;
            btnSave.Text = "Save to";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // lblModifications
            // 
            lblModifications.AutoSize = true;
            lblModifications.Location = new Point(409, 9);
            lblModifications.Margin = new Padding(4, 0, 4, 0);
            lblModifications.Name = "lblModifications";
            lblModifications.Size = new Size(100, 20);
            lblModifications.TabIndex = 15;
            lblModifications.Text = "Modifications";
            // 
            // lblSourcePalette
            // 
            lblSourcePalette.AutoSize = true;
            lblSourcePalette.Location = new Point(876, 67);
            lblSourcePalette.Margin = new Padding(4, 0, 4, 0);
            lblSourcePalette.Name = "lblSourcePalette";
            lblSourcePalette.Size = new Size(103, 20);
            lblSourcePalette.TabIndex = 15;
            lblSourcePalette.Text = "Source Palette";
            // 
            // tlpSourcePalette
            // 
            tlpSourcePalette.ColumnCount = 16;
            tlpSourcePalette.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 23F));
            tlpSourcePalette.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 23F));
            tlpSourcePalette.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 23F));
            tlpSourcePalette.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 23F));
            tlpSourcePalette.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 23F));
            tlpSourcePalette.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 23F));
            tlpSourcePalette.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 23F));
            tlpSourcePalette.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 23F));
            tlpSourcePalette.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 23F));
            tlpSourcePalette.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 23F));
            tlpSourcePalette.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 23F));
            tlpSourcePalette.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 23F));
            tlpSourcePalette.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 23F));
            tlpSourcePalette.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 23F));
            tlpSourcePalette.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 23F));
            tlpSourcePalette.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 25F));
            tlpSourcePalette.Location = new Point(878, 92);
            tlpSourcePalette.Margin = new Padding(4, 5, 4, 5);
            tlpSourcePalette.Name = "tlpSourcePalette";
            tlpSourcePalette.RowCount = 16;
            tlpSourcePalette.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tlpSourcePalette.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tlpSourcePalette.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tlpSourcePalette.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tlpSourcePalette.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tlpSourcePalette.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tlpSourcePalette.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tlpSourcePalette.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tlpSourcePalette.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tlpSourcePalette.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tlpSourcePalette.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tlpSourcePalette.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tlpSourcePalette.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tlpSourcePalette.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tlpSourcePalette.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tlpSourcePalette.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tlpSourcePalette.Size = new Size(368, 416);
            tlpSourcePalette.TabIndex = 1;
            tlpSourcePalette.CellPaint += tlpSourcePalette_CellPaint;
            tlpSourcePalette.Click += tlpSourcePalette_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(878, 516);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(98, 20);
            label7.TabIndex = 15;
            label7.Text = "Result Palette";
            // 
            // cbTargetPalette
            // 
            cbTargetPalette.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTargetPalette.FormattingEnabled = true;
            cbTargetPalette.Items.AddRange(new object[] { "Palette 1", "Palette 2", "Palette 3", "Palette 4", "Palette 5", "Palette 6", "Palette 7", "Palette 8" });
            cbTargetPalette.Location = new Point(533, 908);
            cbTargetPalette.Margin = new Padding(4, 5, 4, 5);
            cbTargetPalette.Name = "cbTargetPalette";
            cbTargetPalette.Size = new Size(160, 28);
            cbTargetPalette.TabIndex = 16;
            // 
            // numCurrentImage
            // 
            numCurrentImage.Location = new Point(251, 436);
            numCurrentImage.Name = "numCurrentImage";
            numCurrentImage.Size = new Size(150, 27);
            numCurrentImage.TabIndex = 17;
            numCurrentImage.ValueChanged += numCurrentImage_ValueChanged;
            // 
            // lblIsPrivatePalette
            // 
            lblIsPrivatePalette.AutoSize = true;
            lblIsPrivatePalette.ForeColor = Color.Red;
            lblIsPrivatePalette.Location = new Point(11, 438);
            lblIsPrivatePalette.Name = "lblIsPrivatePalette";
            lblIsPrivatePalette.Size = new Size(107, 20);
            lblIsPrivatePalette.TabIndex = 18;
            lblIsPrivatePalette.Text = "Private Palette!";
            toolTip1.SetToolTip(lblIsPrivatePalette, "The result palette is not applied to preview images with private palette");
            lblIsPrivatePalette.Visible = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(13, 9);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(105, 20);
            label8.TabIndex = 19;
            label8.Text = "Sample Image";
            // 
            // lblLoadAdvice
            // 
            lblLoadAdvice.AutoSize = true;
            lblLoadAdvice.Location = new Point(115, 232);
            lblLoadAdvice.Name = "lblLoadAdvice";
            lblLoadAdvice.Size = new Size(156, 20);
            lblLoadAdvice.TabIndex = 20;
            lblLoadAdvice.Text = "Load a .player file first";
            lblLoadAdvice.Click += lblLoadAdvice_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1256, 968);
            Controls.Add(lblLoadAdvice);
            Controls.Add(label8);
            Controls.Add(lblIsPrivatePalette);
            Controls.Add(numCurrentImage);
            Controls.Add(cbTargetPalette);
            Controls.Add(label7);
            Controls.Add(lblSourcePalette);
            Controls.Add(lblModifications);
            Controls.Add(btnSave);
            Controls.Add(lstChain);
            Controls.Add(btnOpen);
            Controls.Add(tlpSourcePalette);
            Controls.Add(rbPalette8);
            Controls.Add(rbPalette7);
            Controls.Add(rbPalette6);
            Controls.Add(rbPalette5);
            Controls.Add(rbPalette4);
            Controls.Add(rbPalette3);
            Controls.Add(rbPalette2);
            Controls.Add(rbPalette1);
            Controls.Add(gbColorFilter);
            Controls.Add(groupBox1);
            Controls.Add(tlpResultPalette);
            Controls.Add(pbBitmap);
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmMain";
            Text = "frmMain";
            ((System.ComponentModel.ISupportInitialize)pbBitmap).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbRed).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbGreen).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbBlue).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbH).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbL).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbS).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            gbColorFilter.ResumeLayout(false);
            gbColorFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tbColorFilterRange).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbM).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCurrentImage).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.PictureBox pbBitmap;
        private System.Windows.Forms.TableLayoutPanel tlpResultPalette;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TrackBar tbRed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar tbGreen;
        private System.Windows.Forms.TrackBar tbBlue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar tbH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar tbL;
        private System.Windows.Forms.TrackBar tbS;
        private System.Windows.Forms.Button btnLoadPalettes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbPalette1;
        private System.Windows.Forms.RadioButton rbPalette2;
        private System.Windows.Forms.RadioButton rbPalette3;
        private System.Windows.Forms.RadioButton rbPalette4;
        private System.Windows.Forms.RadioButton rbPalette5;
        private System.Windows.Forms.RadioButton rbPalette6;
        private System.Windows.Forms.RadioButton rbPalette7;
        private System.Windows.Forms.RadioButton rbPalette8;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox gbColorFilter;
        private System.Windows.Forms.Panel pnlFilterColor;
        private System.Windows.Forms.TrackBar tbColorFilterRange;
        private System.Windows.Forms.CheckBox cbColorFilterEnabled;
        private System.Windows.Forms.ListBox lstChain;
        private System.Windows.Forms.CheckBox cbColorChangeEnabled;
        private System.Windows.Forms.TrackBar tbM;
        private System.Windows.Forms.Button btnColorChangeReset;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblColorFilterRange;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblBlend;
        private System.Windows.Forms.Label lblModifications;
        private System.Windows.Forms.Label lblSourcePalette;
        private System.Windows.Forms.TableLayoutPanel tlpSourcePalette;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbTargetPalette;
        private Label lblColorHex;
        private Button btnCopy;
        private NumericUpDown numCurrentImage;
        private Label lblIsPrivatePalette;
        private Label label8;
        private ToolTip toolTip1;
        private Label lblLoadAdvice;
        private Label label9;
        private ComboBox cbComparisonMethod;
    }
}

