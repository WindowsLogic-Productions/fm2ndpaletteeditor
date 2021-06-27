using System.Drawing;

namespace Fm2ndPaletteEditor.Service
{
    public class ColorFilter
    {
        public bool Enabled { get; set; } = false;
        public Color Color { get; set; } = Color.Black;
        public double Fuzziness { get; set; } = 0;
    }
}