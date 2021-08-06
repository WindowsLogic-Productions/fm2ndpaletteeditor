using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Fm2ndPaletteEditor.Service
{
    static class ByteArrayRocks
    {
        static readonly int[] Empty = new int[0];

        public static int[] Locate(this byte[] self)
        {
            var list = new List<int>();

            var patternListGroups = new List<byte?[]>();
            var patternList = new List<byte?>();
            for (int i = 0; i < 32; i++)
                patternList.Add(0);
            patternListGroups.Add(patternList.ToArray());

            patternList = new List<byte?>();
            patternList.Add(null);
            patternList.Add(null);
            patternList.Add(null);
            patternList.Add(1);
            patternListGroups.Add(patternList.ToArray());

            patternList = new List<byte?>();
            patternList.Add(0);
            patternList.Add(0);
            patternList.Add(0);
            patternList.Add(0);
            patternListGroups.Add(patternList.ToArray());

            var next = false;

            for (int p = 0; p < self.Length; p++)
            {
                if (next)
                {
                    list.Clear();
                }
                next = false;

                var np = p;
                if (!IsMatch(self, np, patternListGroups[0]))
                    continue;
                np += patternListGroups[0].Length;

                int colorCount;
                for (colorCount = 0; colorCount < 256; colorCount++)
                {
                    if (!IsMatch(self, np, patternListGroups[1]))
                    {
                        break;
                    }
                    np += patternListGroups[1].Length;
                }
                if (colorCount > 0)
                {
                    for (; colorCount < 256; colorCount++)
                    {
                        if (!IsMatch(self, np, patternListGroups[2]))
                        {
                            next = true;
                            np += patternListGroups[2].Length;
                            break;
                        }
                        np += patternListGroups[2].Length;
                    }

                    if (!next)
                    {
                        list.Add(p);
                        if (list.Count == 8)
                            break;
                        p = np - 1;
                    }
                }
            }

            return list.Count == 0 ? Empty : list.ToArray();
        }

        static bool IsMatch(byte[] array, int position, byte?[] candidate)
        {
            if (candidate.Length > (array.Length - position))
                return false;

            for (int i = 0; i < candidate.Length; i++)
                if (candidate[i] != null &&
                    array[position + i] != candidate[i])
                    return false;

            return true;
        }

        static bool IsEmptyLocate(byte[] array, byte?[] candidate)
        {
            return array == null
                || candidate == null
                || array.Length == 0
                || candidate.Length == 0
                || candidate.Length > array.Length;
        }
    }
}
