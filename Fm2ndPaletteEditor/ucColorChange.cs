using Fm2ndPaletteEditor.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Fm2ndPaletteEditor
{
    public partial class ucColorChange : UserControl
    {
        public ColorChange CurrentColorChange { get; set; }

        public ucColorChange()
        {
            InitializeComponent();
        }

        private void tb_Scroll(object sender, EventArgs e)
        {
            CurrentColorChange.R = tbRed.Value;
            CurrentColorChange.G = tbGreen.Value;
            CurrentColorChange.B = tbBlue.Value;
            CurrentColorChange.H = tbH.Value;
            CurrentColorChange.L = tbL.Value;
            CurrentColorChange.S = tbS.Value;
        }
    }
}
