using MoreLinq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace Fm2ndPaletteEditor.Service
{
    public class Player
    {
        FileStream _stream;
        public Color[][] Palettes;

        public Player(string filename)
        {
            var stream = File.OpenRead(filename);

            this._stream = stream;

            using (MemoryStream ms = new MemoryStream())
            {
                stream.CopyTo(ms);
                var data = ms.ToArray();
                validatePlayer(data);
                Palettes = LoadPalettes(data);
            }
        }

        private void validatePlayer(byte[] data)
        {
            var word = data.Slice(0, 7).ToArray();
            var type = Encoding.Default.GetString(word);
            if (type.StartsWith("2DKGT2G"))
                throw new LockedFileException();
        }

        public Color[][] LoadPalettes(string filename)
        {
            var data = File.ReadAllBytes(filename);
            return LoadPalettes(data);
        }

        public Color[][] LoadPalettes(byte[] data)
        {
            var positions = readPalettesPositions(data);

            var palettesArray = positions.Select(x => data.Skip(x).Take(256 * 4));

            var palettes = palettesArray
                .Select(p => p.Batch(4)
                    .Select(c => parseFM2kColor(c.ToArray())).ToArray()
                ).ToArray();

            return palettes;
        }

        private int[] readPalettesPositions(byte[] data)
        {
            // create patter: 32 zeros 256 ***1
            var patternList = new List<byte?>();
            for (int i = 0; i < 32; i++)
                patternList.Add(0);
            for (int i = 0; i < 256; i++)
            {
                patternList.Add(null);
                patternList.Add(null);
                patternList.Add(null);
                patternList.Add(1);
            }

            var pattern = patternList.ToArray();

            var positions = data.Locate(pattern);
            if (positions.Count() != 8)
            {
                throw new Exception("No correct palette format found");
            }
            return positions.Select(x => x + 32).ToArray();
        }

        public void SavePalettes(string filename, Color[][] palettes)
        {
            var data = File.ReadAllBytes(filename);
            var positions = readPalettesPositions(data);
            using (var stream = File.OpenWrite(filename))
            {
                for (int i = 0; i < palettes.Length; i++)
                {
                    stream.Position = positions[i];
                    var palette = toFM2kPalette(palettes[i]);
                    stream.Write(palette, 0, palette.Length);
                }
            }
        }

        private byte[] toFM2kPalette(Color[] colors)
        {
            var result = colors.SelectMany(x => toFM2kColor(x)).ToArray();
            return result;
        }
        private byte[] toFM2kColor(Color color)
        {
            var r = (byte)((int)Math.Round((double)color.R / 8) * 8);
            var g = (byte)((int)Math.Round((double)color.G / 8) * 8);
            var b = (byte)((int)Math.Round((double)color.B / 8) * 8);

            return new byte[] { b, g, r, 1 };
        }

        private string toFM2kColorString(Color color)
        {
            var colorArray = toFM2kColor(color);
            var result = string.Join(" ", colorArray.Select(x => x.ToString("X2")));

            return result + " ";
        }

        private Color parseFM2kColor(byte[] color)
        {
            if (color.Count() != 4)
                throw new Exception("Wrong format");
            if (color[3] != 1)
                throw new Exception("No global palette");

            var b = color[0];
            var g = color[1];
            var r = color[2];

            var result = Color.FromArgb(r, g, b);
            return result;
        }

        private Color parseFM2kColor(string colorTxt)
        {
            var rgba = colorTxt
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(x => byte.Parse(x, NumberStyles.HexNumber))
                .ToArray();

            return parseFM2kColor(rgba);
        }
    }
}