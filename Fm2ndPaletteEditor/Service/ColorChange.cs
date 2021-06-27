using ImageProcessor.Processors;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fm2ndPaletteEditor.Service
{
   public class ColorChange
    {
        public ColorFilter ColorFilter { get; set; } = new ColorFilter();
        public int R { get; set; }
        public int G { get; set; }
        public int B { get; set; }
        public int H { get; set; }
        public int S { get; set; }
        public int L { get; set; }
    }
}
