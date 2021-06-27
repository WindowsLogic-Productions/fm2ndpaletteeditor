using System;
using System.Collections.Generic;
using System.Text;

namespace Fm2ndPaletteEditor.Service
{
    public class ColorChangeChain
    {
        public IList<ColorChange> ColorChanges { get; set; } = new List<ColorChange> { new ColorChange() };
    }
}
