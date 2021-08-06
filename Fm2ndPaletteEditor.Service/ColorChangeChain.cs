using System;
using System.Collections.Generic;
using System.Text;

namespace Fm2ndPaletteEditor.Service
{
    public class ColorChangeChain
    {
        public IList<ColorChange> ColorChanges { get; set; } = new List<ColorChange> {
            new ColorChange { Idx = 1 },
            new ColorChange { Idx = 2 },
            new ColorChange { Idx = 3 },
            new ColorChange { Idx = 4 },
            new ColorChange { Idx = 5 },
            new ColorChange { Idx = 6 },
            new ColorChange { Idx = 7 },
            new ColorChange { Idx = 8 },
            new ColorChange { Idx = 9 },
            new ColorChange { Idx = 10 },
            new ColorChange { Idx = 11 },
            new ColorChange { Idx = 12 },
        };
    }
}
