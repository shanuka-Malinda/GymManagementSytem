using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace Gym_Management_System
{
    internal class PdfBitmap
    {
        private Bitmap bitmap1;

        public PdfBitmap(Bitmap bitmap1)
        {
            this.bitmap1 = bitmap1;
        }

        internal void Save(FileStream fs, ImageFormat png)
        {
            throw new NotImplementedException();
        }
    }
}