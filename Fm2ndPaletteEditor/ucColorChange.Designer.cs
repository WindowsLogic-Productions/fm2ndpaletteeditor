
namespace Fm2ndPaletteEditor
{
    partial class ucColorChange
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbS = new System.Windows.Forms.TrackBar();
            this.tbBlue = new System.Windows.Forms.TrackBar();
            this.tbL = new System.Windows.Forms.TrackBar();
            this.tbGreen = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbH = new System.Windows.Forms.TrackBar();
            this.tbRed = new System.Windows.Forms.TrackBar();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRed)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbS);
            this.groupBox1.Controls.Add(this.tbBlue);
            this.groupBox1.Controls.Add(this.tbL);
            this.groupBox1.Controls.Add(this.tbGreen);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbH);
            this.groupBox1.Controls.Add(this.tbRed);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 326);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ColorChange";
            // 
            // tbS
            // 
            this.tbS.LargeChange = 32;
            this.tbS.Location = new System.Drawing.Point(30, 274);
            this.tbS.Maximum = 256;
            this.tbS.Minimum = -256;
            this.tbS.Name = "tbS";
            this.tbS.Size = new System.Drawing.Size(318, 45);
            this.tbS.SmallChange = 8;
            this.tbS.TabIndex = 5;
            this.tbS.TickFrequency = 8;
            this.tbS.Scroll += new System.EventHandler(this.tb_Scroll);
            // 
            // tbBlue
            // 
            this.tbBlue.LargeChange = 32;
            this.tbBlue.Location = new System.Drawing.Point(29, 121);
            this.tbBlue.Maximum = 256;
            this.tbBlue.Minimum = -256;
            this.tbBlue.Name = "tbBlue";
            this.tbBlue.Size = new System.Drawing.Size(318, 45);
            this.tbBlue.SmallChange = 8;
            this.tbBlue.TabIndex = 6;
            this.tbBlue.TickFrequency = 8;
            this.tbBlue.Scroll += new System.EventHandler(this.tb_Scroll);
            // 
            // tbL
            // 
            this.tbL.LargeChange = 32;
            this.tbL.Location = new System.Drawing.Point(29, 223);
            this.tbL.Maximum = 256;
            this.tbL.Minimum = -256;
            this.tbL.Name = "tbL";
            this.tbL.Size = new System.Drawing.Size(319, 45);
            this.tbL.SmallChange = 8;
            this.tbL.TabIndex = 7;
            this.tbL.TickFrequency = 8;
            this.tbL.Scroll += new System.EventHandler(this.tb_Scroll);
            // 
            // tbGreen
            // 
            this.tbGreen.LargeChange = 32;
            this.tbGreen.Location = new System.Drawing.Point(28, 70);
            this.tbGreen.Maximum = 256;
            this.tbGreen.Minimum = -256;
            this.tbGreen.Name = "tbGreen";
            this.tbGreen.Size = new System.Drawing.Size(319, 45);
            this.tbGreen.SmallChange = 8;
            this.tbGreen.TabIndex = 8;
            this.tbGreen.TickFrequency = 8;
            this.tbGreen.Scroll += new System.EventHandler(this.tb_Scroll);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(6, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "S";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(5, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "B";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(6, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "L";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(5, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "G";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "H";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "R";
            // 
            // tbH
            // 
            this.tbH.LargeChange = 32;
            this.tbH.Location = new System.Drawing.Point(29, 172);
            this.tbH.Maximum = 256;
            this.tbH.Minimum = -256;
            this.tbH.Name = "tbH";
            this.tbH.Size = new System.Drawing.Size(319, 45);
            this.tbH.SmallChange = 8;
            this.tbH.TabIndex = 9;
            this.tbH.TickFrequency = 8;
            this.tbH.Scroll += new System.EventHandler(this.tb_Scroll);
            // 
            // tbRed
            // 
            this.tbRed.LargeChange = 32;
            this.tbRed.Location = new System.Drawing.Point(28, 19);
            this.tbRed.Maximum = 256;
            this.tbRed.Minimum = -256;
            this.tbRed.Name = "tbRed";
            this.tbRed.Size = new System.Drawing.Size(319, 45);
            this.tbRed.SmallChange = 8;
            this.tbRed.TabIndex = 10;
            this.tbRed.TickFrequency = 8;
            this.tbRed.Scroll += new System.EventHandler(this.tb_Scroll);
            // 
            // ucColorChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "ucColorChange";
            this.Size = new System.Drawing.Size(355, 326);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRed)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TrackBar tbS;
        private System.Windows.Forms.TrackBar tbBlue;
        private System.Windows.Forms.TrackBar tbL;
        private System.Windows.Forms.TrackBar tbGreen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar tbH;
        private System.Windows.Forms.TrackBar tbRed;
    }
}
