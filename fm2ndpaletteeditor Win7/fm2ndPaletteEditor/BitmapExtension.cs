using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace Fm2ndPaletteEditor
{

    public static class BitmapExtensions
    {
        public static int GetPixelPaletteIndex(this Bitmap bitmap, int x, int y)
        {
            // Controlla che l'immagine sia effettivamente indicizzata
            if ((bitmap.PixelFormat & PixelFormat.Indexed) == 0)
            {
                throw new ArgumentException("La bitmap non è in un formato indicizzato (es. non è 8bpp o 4bpp).");
            }

            // Blocca i bit dell'immagine in memoria per una lettura sicura e veloce
            Rectangle rect = new Rectangle(0, 0, bitmap.Width, bitmap.Height);
            BitmapData bmpData = bitmap.LockBits(rect, ImageLockMode.ReadOnly, bitmap.PixelFormat);

            try
            {
                // Calcola l'indirizzo di memoria della riga interessata
                // Stride è la larghezza effettiva in byte di una riga in memoria (inclusi i padding)
                IntPtr rowAddress = bmpData.Scan0 + (y * bmpData.Stride);

                if (bitmap.PixelFormat == PixelFormat.Format8bppIndexed)
                {
                    // A 8-bit, 1 pixel = 1 byte. L'indice della palette è il valore del byte.
                    return Marshal.ReadByte(rowAddress, x);
                }
                else if (bitmap.PixelFormat == PixelFormat.Format4bppIndexed)
                {
                    // A 4-bit, 1 byte contiene 2 pixel (4 bit ciascuno).
                    // Dobbiamo capire se il pixel è nella prima o nella seconda metà del byte.
                    int byteOffset = x / 2;
                    int rawByte = Marshal.ReadByte(rowAddress, byteOffset);

                    if (x % 2 == 0)
                    {
                        // Pixel nei 4 bit alti (i primi 4 bit del byte)
                        return (rawByte >> 4) & 0x0F;
                    }
                    else
                    {
                        // Pixel nei 4 bit bassi (gli ultimi 4 bit del byte)
                        return rawByte & 0x0F;
                    }
                }
                else if (bitmap.PixelFormat == PixelFormat.Format1bppIndexed)
                {
                    // A 1-bit (Bianco/Nero), 1 byte = 8 pixel.
                    int byteOffset = x / 8;
                    int bitOffset = 7 - (x % 8);
                    int rawByte = Marshal.ReadByte(rowAddress, byteOffset);
                    return (rawByte >> bitOffset) & 0x01;
                }

                throw new NotSupportedException($"Formato indicizzato {bitmap.PixelFormat} non supportato direttamente.");
            }
            finally
            {
                // IMPORTANTE: Rilascia sempre i bit, altrimenti crei un memory leak massivo
                bitmap.UnlockBits(bmpData);
            }
        }
    }
}
