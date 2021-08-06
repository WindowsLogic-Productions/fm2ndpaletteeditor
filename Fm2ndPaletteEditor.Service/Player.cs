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
        public string FileName;
        FileStream _stream;
        int[] _palettePositions;
        public Color[][] Palettes;

        public Player(string filename)
        {
            this.FileName = filename;
            try
            {
                var stream = File.Open(this.FileName, FileMode.Open, FileAccess.ReadWrite);

                this._stream = stream;

                using (MemoryStream ms = new MemoryStream())
                {
                    stream.CopyTo(ms);
                    var data = ms.ToArray();
                    validatePlayer(data);
                    Palettes = loadPalettes(data);
                }
            }
            catch (Exception e)
            {
                this.Close();
                throw e;
            }
        }

        private void Close()
        {
            FileName = null;
            _palettePositions = null;
            Palettes = null;
            if (_stream != null)
            {
                _stream.Close();
            }
        }

        private void validatePlayer(byte[] data)
        {
            var word = data.Slice(0, 7).ToArray();
            var type = Encoding.Default.GetString(word);
            if (type.StartsWith("2DKGT2G"))
                throw new LockedFileException();
        }

        private Color[][] loadPalettes(byte[] data)
        {
            _palettePositions = readPalettesPositions(data);

            var palettesArray = _palettePositions.Select(x => data.Skip(x).Take(256 * 4));

            var palettes = palettesArray
                .Select(p => p.Batch(4)
                    .Select(c => parseFM2kColor(c.ToArray())).ToArray()
                ).ToArray();

            return palettes;
        }

        private int[] readPalettesPositions(byte[] data)
        {
            var positions = data.Locate();

            if (positions.Count() != 8)
            {
                throw new Exception("No correct palette format found");
            }
            return positions.Select(x => x + 32).ToArray();
        }

        public void SavePalette(Color[] palette, int targetNumber)
        {
            this.Palettes[targetNumber] = palette;
            savePalette(_stream, palette, _palettePositions[targetNumber]);
        }

        private void savePalette(Stream stream, Color[] palette, long position)
        {
            stream.Position = position;
            var paletteBytes = toFM2kPalette(palette);
            stream.Write(paletteBytes, 0, paletteBytes.Length);
        }

        private byte[] toFM2kPalette(Color[] colors)
        {
            var result = colors.SelectMany(x => toFM2kColor(x)).ToArray();
            return result;
        }

        private byte[] toFM2kColor(Color color)
        {
            if (color.A == 255)
            {
                var r = (byte)Math.Min((int)Math.Round((double)color.R / 8) * 8, 255);
                var g = (byte)Math.Min((int)Math.Round((double)color.G / 8) * 8, 255);
                var b = (byte)Math.Min((int)Math.Round((double)color.B / 8) * 8, 255);

                return new byte[] { b, g, r, 1 };
            }
            else
            {
                return new byte[] { 0, 0, 0, 0 };
            }
        }

        private string toFM2kColorString(Color color)
        {
            var colorArray = toFM2kColor(color);
            var result = string.Join(" ", colorArray.Select(x => x.ToString("X2")));

            return result + " ";
        }

        private Color parseFM2kColor(byte[] color)
        {
            if (color.Count() != 4 && color[3] != 1 && color[3] != 0)
                throw new Exception("Wrong format");

            var b = color[0];
            var g = color[1];
            var r = color[2];

            //if (r % 8 != 0 || g % 8 != 0 || b % 8 != 0)
            //    throw new Exception("Wrong format");

            var a = color[3] == 0 ? 0 : 255;

            var result = Color.FromArgb(a, r, g, b);
            return result;
        }

        private Color parseFM2kColor(string colorTxt)
        {
            var rgba = colorTxt
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => byte.Parse(x, NumberStyles.HexNumber))
                .ToArray();

            return parseFM2kColor(rgba);
        }
    }
}