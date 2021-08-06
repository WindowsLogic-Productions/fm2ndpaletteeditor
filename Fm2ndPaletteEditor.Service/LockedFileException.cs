using System;
using System.Runtime.Serialization;

namespace Fm2ndPaletteEditor.Service
{
    [Serializable]
    internal class LockedFileException : Exception
    {
        public LockedFileException(): base("Locked files cannot be openen")
        {
        }

        public LockedFileException(Exception innerException) : base("Locked files cannot be openen", innerException)
        {
        }
    }
}