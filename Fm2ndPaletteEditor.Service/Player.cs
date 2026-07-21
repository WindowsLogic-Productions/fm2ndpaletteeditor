using Fm2ndParser;
using Fm2ndParser.Character;
using Fm2ndParser.Common;
using Fm2ndParser.Parsers;
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
        public Palette[] Palettes;
        private PlayerParser _parser;
        private PlayerFile _player;

        public Player(string filename)
        {
            this.FileName = filename;
            _parser = new PlayerParser(filename, null);
            _player = _parser.Parse();

            Palettes = _player.GlobalPalettes.ToArray();
        }

        public int ImagesCount { get { return _player.Images.Count - 1; } }

        public bool IsPrivatePalette(int value)
        {
            return _player.Images.ElementAt(value).PaletteType == PaletteType.Private;
        }

        public Stream LoadImage(int i, int paletteIndex)
        {
            var image = _player.Images.ElementAt(i);
            var palette = image.PaletteType == PaletteType.Global ? _player.GlobalPalettes.ElementAt(paletteIndex) : null;
            return ParseCommand.ToIndexedBmpStream(image, palette);
        }

        public void SavePalette(Color[] paletteColors, int index)
        {
            var palette = _player.GlobalPalettes.ElementAt(index);
            palette.Data = ParseCommand.ToFM2kPalette(paletteColors);
            palette.Colors = paletteColors.Clone() as Color[];

            // backup file before write
            var backupFilename = getBackupFilename(FileName);
            File.Copy(FileName, backupFilename, false);

            using var stream = File.OpenWrite(FileName);
            using var writer = new BinaryWriter(stream);
            writer.Seek(palette.Position, SeekOrigin.Begin);
            writer.Write(palette.Data);
        }

        private string getBackupFilename(string originalFilename)
        {
            // Estrae il percorso della cartella (es. "C:\MieiFile")
            string directory = Path.GetDirectoryName(originalFilename) ?? string.Empty;

            // Estrae il nome del file senza estensione (es. "documento")
            string fileNameWithoutExt = Path.GetFileNameWithoutExtension(originalFilename);

            // Estrae l'estensione (es. ".dat")
            string extension = Path.GetExtension(originalFilename);

            // Crea un timestamp preciso al secondo (es. "20260719_130132")
            string timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");

            // Compone il nuovo nome: "documento_backup_20260719_130132.dat"
            string backupFileName = $"{fileNameWithoutExt}_backup_{timestamp}{extension}";

            // Combina la cartella originale con il nuovo nome file
            return Path.Combine(directory, backupFileName);
        }
    }
}