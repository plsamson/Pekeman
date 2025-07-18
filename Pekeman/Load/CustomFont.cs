using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Pekeman
{
    class CustomFont
    {
        private static PrivateFontCollection textFont;
        public static Font big;
        public static Font standard;
        public static Font small;

        static CustomFont()
        {
            textFont = new PrivateFontCollection();

            byte[] fontData = Properties.Resources.PixelFont;

            IntPtr fontPtr = Marshal.AllocCoTaskMem(fontData.Length);

            Marshal.Copy(fontData, 0, fontPtr, fontData.Length);

            textFont.AddMemoryFont(fontPtr, fontData.Length);

            Marshal.FreeCoTaskMem(fontPtr);

            big = new Font(CustomFont.textFont.Families[0], 14);
            standard = new Font(CustomFont.textFont.Families[0], 12);
            small = new Font(CustomFont.textFont.Families[0], 9);
        }
    }
}
