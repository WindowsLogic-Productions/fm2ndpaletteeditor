using System.Drawing;

namespace Fm2ndPaletteEditor.Service
{
    public class ColorFilter
    {
        public int PaletteIdx { get; set; }
        public bool Enabled { get; set; } = false;
        public Color Color { get; set; } = Color.Black;
        public double Range { get; set; } = 0;
        public double M { get; set; } = 0;
        public ColorComparison Comparison { get; set; } = ColorComparison.Cie1976;
    }
}
