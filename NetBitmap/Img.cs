using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Media.Imaging;

namespace NetBitmap
{
    public class Img
    {
        private readonly Bitmap _bitmap;
        private readonly BitmapImage _bitmapImage;
        private readonly WriteableBitmap _writeableBitmap;

        public Img(Bitmap bitmap)
        {
            _bitmap = bitmap;
        }

        public Img(BitmapImage bitmapImage)
        {
            _bitmapImage = bitmapImage;
        }

        public Img(WriteableBitmap writeableBitmap)
        {
            _writeableBitmap = writeableBitmap;
        }

        public Bitmap Bitmap
        {
            get
            {
                return _bitmap;
            }
        }

        public BitmapImage BitmapImage
        {
            get
            {
                return _bitmapImage;
            }
        }

        public WriteableBitmap WriteableBitmap
        {
            get
            {
                return _writeableBitmap;
            }
        }
    }
}
