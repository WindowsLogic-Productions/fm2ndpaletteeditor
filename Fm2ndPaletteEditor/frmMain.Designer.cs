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
            this.pbBitmap = new System.Windows.Forms.PictureBox();
            this.tlpResultPalette = new System.Windows.Forms.TableLayoutPanel();
            this.tbRed = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.tbGreen = new System.Windows.Forms.TrackBar();
            this.tbBlue = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbH = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbL = new System.Windows.Forms.TrackBar();
            this.tbS = new System.Windows.Forms.TrackBar();
            this.lblImageHint = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnColorChangeReset = new System.Windows.Forms.Button();
            this.cbColorChangeEnabled = new System.Windows.Forms.CheckBox();
            this.rbPalette1 = new System.Windows.Forms.RadioButton();
            this.rbPalette2 = new System.Windows.Forms.RadioButton();
            this.rbPalette3 = new System.Windows.Forms.RadioButton();
            this.rbPalette4 = new System.Windows.Forms.RadioButton();
            this.rbPalette5 = new System.Windows.Forms.RadioButton();
            this.rbPalette6 = new System.Windows.Forms.RadioButton();
            this.rbPalette7 = new System.Windows.Forms.RadioButton();
            this.rbPalette8 = new System.Windows.Forms.RadioButton();
            this.btnOpen = new System.Windows.Forms.Button();
            this.gbColorFilter = new System.Windows.Forms.GroupBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.cbColorFilterEnabled = new System.Windows.Forms.CheckBox();
            this.lblTolerance = new System.Windows.Forms.Label();
            this.pnlFilterColor = new System.Windows.Forms.Panel();
            this.tbColorFilterFuzziness = new System.Windows.Forms.TrackBar();
            this.tbM = new System.Windows.Forms.TrackBar();
            this.lblFuzziness = new System.Windows.Forms.Label();
            this.lstChain = new System.Windows.Forms.ListBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblModifications = new System.Windows.Forms.Label();
            this.lblSourcePalette = new System.Windows.Forms.Label();
            this.tlpSourcePalette = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.cbTargetPalette = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbBitmap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbS)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gbColorFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbColorFilterFuzziness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbM)).BeginInit();
            this.SuspendLayout();
            // 
            // pbBitmap
            // 
            this.pbBitmap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbBitmap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbBitmap.Location = new System.Drawing.Point(10, 10);
            this.pbBitmap.Name = "pbBitmap";
            this.pbBitmap.Size = new System.Drawing.Size(292, 291);
            this.pbBitmap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBitmap.TabIndex = 0;
            this.pbBitmap.TabStop = false;
            this.pbBitmap.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // tlpResultPalette
            // 
            this.tlpResultPalette.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpResultPalette.ColumnCount = 16;
            this.tlpResultPalette.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tlpResultPalette.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tlpResultPalette.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tlpResultPalette.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tlpResultPalette.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tlpResultPalette.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tlpResultPalette.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tlpResultPalette.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tlpResultPalette.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tlpResultPalette.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tlpResultPalette.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tlpResultPalette.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tlpResultPalette.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tlpResultPalette.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tlpResultPalette.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tlpResultPalette.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.tlpResultPalette.Location = new System.Drawing.Point(657, 356);
            this.tlpResultPalette.Name = "tlpResultPalette";
            this.tlpResultPalette.RowCount = 16;
            this.tlpResultPalette.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tlpResultPalette.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tlpResultPalette.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tlpResultPalette.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tlpResultPalette.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tlpResultPalette.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tlpResultPalette.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tlpResultPalette.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tlpResultPalette.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tlpResultPalette.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tlpResultPalette.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tlpResultPalette.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tlpResultPalette.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tlpResultPalette.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tlpResultPalette.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tlpResultPalette.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tlpResultPalette.Size = new System.Drawing.Size(274, 277);
            this.tlpResultPalette.TabIndex = 1;
            this.tlpResultPalette.CellPaint += new System.Windows.Forms.TableLayoutCellPaintEventHandler(this.tlpResultPalette_CellPaint);
            // 
            // tbRed
            // 
            this.tbRed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRed.LargeChange = 32;
            this.tbRed.Location = new System.Drawing.Point(23, 42);
            this.tbRed.Maximum = 256;
            this.tbRed.Minimum = -256;
            this.tbRed.Name = "tbRed";
            this.tbRed.Size = new System.Drawing.Size(262, 45);
            this.tbRed.SmallChange = 8;
            this.tbRed.TabIndex = 3;
            this.tbRed.TickFrequency = 8;
            this.tbRed.Scroll += new System.EventHandler(this.tb_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "R";
            // 
            // tbGreen
            // 
            this.tbGreen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbGreen.LargeChange = 32;
            this.tbGreen.Location = new System.Drawing.Point(23, 87);
            this.tbGreen.Maximum = 256;
            this.tbGreen.Minimum = -256;
            this.tbGreen.Name = "tbGreen";
            this.tbGreen.Size = new System.Drawing.Size(262, 45);
            this.tbGreen.SmallChange = 8;
            this.tbGreen.TabIndex = 3;
            this.tbGreen.TickFrequency = 8;
            this.tbGreen.Scroll += new System.EventHandler(this.tb_Scroll);
            // 
            // tbBlue
            // 
            this.tbBlue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbBlue.LargeChange = 32;
            this.tbBlue.Location = new System.Drawing.Point(24, 131);
            this.tbBlue.Maximum = 256;
            this.tbBlue.Minimum = -256;
            this.tbBlue.Name = "tbBlue";
            this.tbBlue.Size = new System.Drawing.Size(261, 45);
            this.tbBlue.SmallChange = 8;
            this.tbBlue.TabIndex = 3;
            this.tbBlue.TickFrequency = 8;
            this.tbBlue.Scroll += new System.EventHandler(this.tb_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "G";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "B";
            // 
            // tbH
            // 
            this.tbH.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbH.LargeChange = 32;
            this.tbH.Location = new System.Drawing.Point(24, 175);
            this.tbH.Maximum = 180;
            this.tbH.Minimum = -180;
            this.tbH.Name = "tbH";
            this.tbH.Size = new System.Drawing.Size(262, 45);
            this.tbH.SmallChange = 8;
            this.tbH.TabIndex = 3;
            this.tbH.TickFrequency = 8;
            this.tbH.Scroll += new System.EventHandler(this.tb_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "H";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "L";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "S";
            // 
            // tbL
            // 
            this.tbL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbL.LargeChange = 32;
            this.tbL.Location = new System.Drawing.Point(24, 219);
            this.tbL.Maximum = 256;
            this.tbL.Minimum = -256;
            this.tbL.Name = "tbL";
            this.tbL.Size = new System.Drawing.Size(262, 45);
            this.tbL.SmallChange = 8;
            this.tbL.TabIndex = 3;
            this.tbL.TickFrequency = 8;
            this.tbL.Scroll += new System.EventHandler(this.tb_Scroll);
            // 
            // tbS
            // 
            this.tbS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbS.LargeChange = 32;
            this.tbS.Location = new System.Drawing.Point(25, 263);
            this.tbS.Maximum = 256;
            this.tbS.Minimum = -256;
            this.tbS.Name = "tbS";
            this.tbS.Size = new System.Drawing.Size(261, 45);
            this.tbS.SmallChange = 8;
            this.tbS.TabIndex = 3;
            this.tbS.TickFrequency = 8;
            this.tbS.Scroll += new System.EventHandler(this.tb_Scroll);
            // 
            // lblImageHint
            // 
            this.lblImageHint.AutoSize = true;
            this.lblImageHint.Location = new System.Drawing.Point(84, 151);
            this.lblImageHint.Name = "lblImageHint";
            this.lblImageHint.Size = new System.Drawing.Size(132, 13);
            this.lblImageHint.TabIndex = 5;
            this.lblImageHint.Text = "Click to load sample image";
            this.lblImageHint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnColorChangeReset);
            this.groupBox1.Controls.Add(this.cbColorChangeEnabled);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbRed);
            this.groupBox1.Controls.Add(this.tbH);
            this.groupBox1.Controls.Add(this.tbS);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbBlue);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbL);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbGreen);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(308, 311);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 319);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Color Change";
            // 
            // btnColorChangeReset
            // 
            this.btnColorChangeReset.Location = new System.Drawing.Point(210, 14);
            this.btnColorChangeReset.Name = "btnColorChangeReset";
            this.btnColorChangeReset.Size = new System.Drawing.Size(75, 24);
            this.btnColorChangeReset.TabIndex = 6;
            this.btnColorChangeReset.Text = "Reset";
            this.btnColorChangeReset.UseVisualStyleBackColor = true;
            this.btnColorChangeReset.Click += new System.EventHandler(this.btnColorChangeReset_Click);
            // 
            // cbColorChangeEnabled
            // 
            this.cbColorChangeEnabled.AutoSize = true;
            this.cbColorChangeEnabled.Location = new System.Drawing.Point(7, 19);
            this.cbColorChangeEnabled.Name = "cbColorChangeEnabled";
            this.cbColorChangeEnabled.Size = new System.Drawing.Size(65, 17);
            this.cbColorChangeEnabled.TabIndex = 5;
            this.cbColorChangeEnabled.Text = "Enabled";
            this.cbColorChangeEnabled.UseVisualStyleBackColor = true;
            this.cbColorChangeEnabled.CheckedChanged += new System.EventHandler(this.cbColorChangeEnabled_CheckedChanged);
            // 
            // rbPalette1
            // 
            this.rbPalette1.AutoSize = true;
            this.rbPalette1.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rbPalette1.Checked = true;
            this.rbPalette1.Location = new System.Drawing.Point(668, 24);
            this.rbPalette1.Name = "rbPalette1";
            this.rbPalette1.Size = new System.Drawing.Size(17, 30);
            this.rbPalette1.TabIndex = 10;
            this.rbPalette1.TabStop = true;
            this.rbPalette1.Text = "1";
            this.rbPalette1.UseVisualStyleBackColor = true;
            this.rbPalette1.CheckedChanged += new System.EventHandler(this.rbPalette1_CheckedChanged);
            // 
            // rbPalette2
            // 
            this.rbPalette2.AutoSize = true;
            this.rbPalette2.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rbPalette2.Location = new System.Drawing.Point(702, 24);
            this.rbPalette2.Name = "rbPalette2";
            this.rbPalette2.Size = new System.Drawing.Size(17, 30);
            this.rbPalette2.TabIndex = 10;
            this.rbPalette2.Text = "2";
            this.rbPalette2.UseVisualStyleBackColor = true;
            this.rbPalette2.CheckedChanged += new System.EventHandler(this.rbPalette2_CheckedChanged);
            // 
            // rbPalette3
            // 
            this.rbPalette3.AutoSize = true;
            this.rbPalette3.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rbPalette3.Location = new System.Drawing.Point(736, 24);
            this.rbPalette3.Name = "rbPalette3";
            this.rbPalette3.Size = new System.Drawing.Size(17, 30);
            this.rbPalette3.TabIndex = 10;
            this.rbPalette3.Text = "3";
            this.rbPalette3.UseVisualStyleBackColor = true;
            this.rbPalette3.CheckedChanged += new System.EventHandler(this.rbPalette3_CheckedChanged);
            // 
            // rbPalette4
            // 
            this.rbPalette4.AutoSize = true;
            this.rbPalette4.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rbPalette4.Location = new System.Drawing.Point(771, 24);
            this.rbPalette4.Name = "rbPalette4";
            this.rbPalette4.Size = new System.Drawing.Size(17, 30);
            this.rbPalette4.TabIndex = 10;
            this.rbPalette4.Text = "4";
            this.rbPalette4.UseVisualStyleBackColor = true;
            this.rbPalette4.CheckedChanged += new System.EventHandler(this.rbPalette4_CheckedChanged);
            // 
            // rbPalette5
            // 
            this.rbPalette5.AutoSize = true;
            this.rbPalette5.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rbPalette5.Location = new System.Drawing.Point(805, 24);
            this.rbPalette5.Name = "rbPalette5";
            this.rbPalette5.Size = new System.Drawing.Size(17, 30);
            this.rbPalette5.TabIndex = 10;
            this.rbPalette5.Text = "5";
            this.rbPalette5.UseVisualStyleBackColor = true;
            this.rbPalette5.CheckedChanged += new System.EventHandler(this.rbPalette5_CheckedChanged);
            // 
            // rbPalette6
            // 
            this.rbPalette6.AutoSize = true;
            this.rbPalette6.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rbPalette6.Location = new System.Drawing.Point(839, 24);
            this.rbPalette6.Name = "rbPalette6";
            this.rbPalette6.Size = new System.Drawing.Size(17, 30);
            this.rbPalette6.TabIndex = 10;
            this.rbPalette6.Text = "6";
            this.rbPalette6.UseVisualStyleBackColor = true;
            this.rbPalette6.CheckedChanged += new System.EventHandler(this.rbPalette6_CheckedChanged);
            // 
            // rbPalette7
            // 
            this.rbPalette7.AutoSize = true;
            this.rbPalette7.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rbPalette7.Location = new System.Drawing.Point(873, 24);
            this.rbPalette7.Name = "rbPalette7";
            this.rbPalette7.Size = new System.Drawing.Size(17, 30);
            this.rbPalette7.TabIndex = 10;
            this.rbPalette7.Text = "7";
            this.rbPalette7.UseVisualStyleBackColor = true;
            this.rbPalette7.CheckedChanged += new System.EventHandler(this.rbPalette7_CheckedChanged);
            // 
            // rbPalette8
            // 
            this.rbPalette8.AutoSize = true;
            this.rbPalette8.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rbPalette8.Location = new System.Drawing.Point(908, 24);
            this.rbPalette8.Name = "rbPalette8";
            this.rbPalette8.Size = new System.Drawing.Size(17, 30);
            this.rbPalette8.TabIndex = 10;
            this.rbPalette8.Text = "8";
            this.rbPalette8.UseVisualStyleBackColor = true;
            this.rbPalette8.CheckedChanged += new System.EventHandler(this.rbPalette8_CheckedChanged);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(12, 713);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(87, 20);
            this.btnOpen.TabIndex = 11;
            this.btnOpen.Text = "Open Player File";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // gbColorFilter
            // 
            this.gbColorFilter.Controls.Add(this.lblColor);
            this.gbColorFilter.Controls.Add(this.cbColorFilterEnabled);
            this.gbColorFilter.Controls.Add(this.lblTolerance);
            this.gbColorFilter.Controls.Add(this.pnlFilterColor);
            this.gbColorFilter.Controls.Add(this.tbColorFilterFuzziness);
            this.gbColorFilter.Controls.Add(this.tbM);
            this.gbColorFilter.Controls.Add(this.lblFuzziness);
            this.gbColorFilter.Location = new System.Drawing.Point(10, 333);
            this.gbColorFilter.Name = "gbColorFilter";
            this.gbColorFilter.Size = new System.Drawing.Size(291, 297);
            this.gbColorFilter.TabIndex = 8;
            this.gbColorFilter.TabStop = false;
            this.gbColorFilter.Text = "Filter";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(10, 49);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(31, 13);
            this.lblColor.TabIndex = 13;
            this.lblColor.Text = "Color";
            // 
            // cbColorFilterEnabled
            // 
            this.cbColorFilterEnabled.AutoSize = true;
            this.cbColorFilterEnabled.Location = new System.Drawing.Point(5, 17);
            this.cbColorFilterEnabled.Name = "cbColorFilterEnabled";
            this.cbColorFilterEnabled.Size = new System.Drawing.Size(65, 17);
            this.cbColorFilterEnabled.TabIndex = 12;
            this.cbColorFilterEnabled.Text = "Enabled";
            this.cbColorFilterEnabled.UseVisualStyleBackColor = true;
            this.cbColorFilterEnabled.CheckedChanged += new System.EventHandler(this.cbColorFilterEnabled_CheckedChanged);
            // 
            // lblTolerance
            // 
            this.lblTolerance.AutoSize = true;
            this.lblTolerance.Location = new System.Drawing.Point(10, 156);
            this.lblTolerance.Name = "lblTolerance";
            this.lblTolerance.Size = new System.Drawing.Size(55, 13);
            this.lblTolerance.TabIndex = 13;
            this.lblTolerance.Text = "Tolerance";
            // 
            // pnlFilterColor
            // 
            this.pnlFilterColor.Location = new System.Drawing.Point(6, 65);
            this.pnlFilterColor.Name = "pnlFilterColor";
            this.pnlFilterColor.Size = new System.Drawing.Size(279, 36);
            this.pnlFilterColor.TabIndex = 5;
            this.pnlFilterColor.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlFilterColor_Paint);
            // 
            // tbColorFilterFuzziness
            // 
            this.tbColorFilterFuzziness.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbColorFilterFuzziness.LargeChange = 100;
            this.tbColorFilterFuzziness.Location = new System.Drawing.Point(6, 124);
            this.tbColorFilterFuzziness.Maximum = 1000;
            this.tbColorFilterFuzziness.Name = "tbColorFilterFuzziness";
            this.tbColorFilterFuzziness.Size = new System.Drawing.Size(279, 45);
            this.tbColorFilterFuzziness.SmallChange = 10;
            this.tbColorFilterFuzziness.TabIndex = 3;
            this.tbColorFilterFuzziness.TickFrequency = 8;
            this.tbColorFilterFuzziness.Scroll += new System.EventHandler(this.tbColorFilterFuzziness_Scroll);
            // 
            // tbM
            // 
            this.tbM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbM.LargeChange = 100;
            this.tbM.Location = new System.Drawing.Point(6, 175);
            this.tbM.Maximum = 10000;
            this.tbM.Name = "tbM";
            this.tbM.Size = new System.Drawing.Size(279, 45);
            this.tbM.SmallChange = 10;
            this.tbM.TabIndex = 3;
            this.tbM.TickFrequency = 8;
            this.tbM.Scroll += new System.EventHandler(this.tbColorFilterFuzziness_Scroll);
            // 
            // lblFuzziness
            // 
            this.lblFuzziness.AutoSize = true;
            this.lblFuzziness.Location = new System.Drawing.Point(10, 108);
            this.lblFuzziness.Name = "lblFuzziness";
            this.lblFuzziness.Size = new System.Drawing.Size(53, 13);
            this.lblFuzziness.TabIndex = 13;
            this.lblFuzziness.Text = "Fuzziness";
            // 
            // lstChain
            // 
            this.lstChain.DisplayMember = "Idx";
            this.lstChain.FormattingEnabled = true;
            this.lstChain.Location = new System.Drawing.Point(307, 24);
            this.lstChain.Name = "lstChain";
            this.lstChain.Size = new System.Drawing.Size(346, 277);
            this.lstChain.TabIndex = 12;
            this.lstChain.SelectedIndexChanged += new System.EventHandler(this.lstChain_SelectedIndexChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(719, 713);
            this.btnSave.Name = "btnSave";
            this.btnSave.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnSave.Size = new System.Drawing.Size(87, 20);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save to";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblModifications
            // 
            this.lblModifications.AutoSize = true;
            this.lblModifications.Location = new System.Drawing.Point(307, 10);
            this.lblModifications.Name = "lblModifications";
            this.lblModifications.Size = new System.Drawing.Size(69, 13);
            this.lblModifications.TabIndex = 15;
            this.lblModifications.Text = "Modifications";
            // 
            // lblSourcePalette
            // 
            this.lblSourcePalette.AutoSize = true;
            this.lblSourcePalette.Location = new System.Drawing.Point(654, 8);
            this.lblSourcePalette.Name = "lblSourcePalette";
            this.lblSourcePalette.Size = new System.Drawing.Size(77, 13);
            this.lblSourcePalette.TabIndex = 15;
            this.lblSourcePalette.Text = "Source Palette";
            // 
            // tlpSourcePalette
            // 
            this.tlpSourcePalette.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpSourcePalette.ColumnCount = 16;
            this.tlpSourcePalette.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tlpSourcePalette.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tlpSourcePalette.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tlpSourcePalette.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tlpSourcePalette.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tlpSourcePalette.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tlpSourcePalette.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tlpSourcePalette.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tlpSourcePalette.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tlpSourcePalette.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tlpSourcePalette.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tlpSourcePalette.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tlpSourcePalette.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tlpSourcePalette.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tlpSourcePalette.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tlpSourcePalette.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.tlpSourcePalette.Location = new System.Drawing.Point(659, 60);
            this.tlpSourcePalette.Name = "tlpSourcePalette";
            this.tlpSourcePalette.RowCount = 16;
            this.tlpSourcePalette.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tlpSourcePalette.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tlpSourcePalette.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tlpSourcePalette.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tlpSourcePalette.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tlpSourcePalette.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tlpSourcePalette.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tlpSourcePalette.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tlpSourcePalette.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tlpSourcePalette.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tlpSourcePalette.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tlpSourcePalette.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tlpSourcePalette.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tlpSourcePalette.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tlpSourcePalette.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tlpSourcePalette.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tlpSourcePalette.Size = new System.Drawing.Size(274, 277);
            this.tlpSourcePalette.TabIndex = 1;
            this.tlpSourcePalette.CellPaint += new System.Windows.Forms.TableLayoutCellPaintEventHandler(this.tlpSourcePalette_CellPaint);
            this.tlpSourcePalette.Click += new System.EventHandler(this.tlpSourcePalette_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(654, 340);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Result Palette";
            // 
            // cbTargetPalette
            // 
            this.cbTargetPalette.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTargetPalette.FormattingEnabled = true;
            this.cbTargetPalette.Items.AddRange(new object[] {
            "Palette 1",
            "Palette 2",
            "Palette 3",
            "Palette 4",
            "Palette 5",
            "Palette 6",
            "Palette 7",
            "Palette 8"});
            this.cbTargetPalette.Location = new System.Drawing.Point(812, 712);
            this.cbTargetPalette.Name = "cbTargetPalette";
            this.cbTargetPalette.Size = new System.Drawing.Size(121, 21);
            this.cbTargetPalette.TabIndex = 16;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 745);
            this.Controls.Add(this.cbTargetPalette);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblSourcePalette);
            this.Controls.Add(this.lblModifications);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lstChain);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.tlpSourcePalette);
            this.Controls.Add(this.rbPalette8);
            this.Controls.Add(this.rbPalette7);
            this.Controls.Add(this.rbPalette6);
            this.Controls.Add(this.rbPalette5);
            this.Controls.Add(this.rbPalette4);
            this.Controls.Add(this.rbPalette3);
            this.Controls.Add(this.rbPalette2);
            this.Controls.Add(this.rbPalette1);
            this.Controls.Add(this.gbColorFilter);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tlpResultPalette);
            this.Controls.Add(this.lblImageHint);
            this.Controls.Add(this.pbBitmap);
            this.Name = "frmMain";
            this.Text = "frmMain";
            ((System.ComponentModel.ISupportInitialize)(this.pbBitmap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbS)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbColorFilter.ResumeLayout(false);
            this.gbColorFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbColorFilterFuzziness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label lblImageHint;
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
        private System.Windows.Forms.TrackBar tbColorFilterFuzziness;
        private System.Windows.Forms.CheckBox cbColorFilterEnabled;
        private System.Windows.Forms.ListBox lstChain;
        private System.Windows.Forms.CheckBox cbColorChangeEnabled;
        private System.Windows.Forms.TrackBar tbM;
        private System.Windows.Forms.Button btnColorChangeReset;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblFuzziness;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblTolerance;
        private System.Windows.Forms.Label lblModifications;
        private System.Windows.Forms.Label lblSourcePalette;
        private System.Windows.Forms.TableLayoutPanel tlpSourcePalette;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbTargetPalette;
    }
}

