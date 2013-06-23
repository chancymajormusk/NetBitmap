using System;
using System.Drawing;
using System.Windows.Media.Imaging;

namespace NetBitmap.Core.ImageContainers
{
    public class StringContainer : IImageContainer
    {
        private readonly Uri _bitmapLocation;

        public StringContainer(string bitmapLocation, UriKind pathFormat)
        {
            _bitmapLocation = new Uri(bitmapLocation, pathFormat);

            Initialize();
        }

        public StringContainer(Uri bitmapLocation)
        {
            _bitmapLocation = bitmapLocation;

            Initialize();
        }

        private void Initialize()
        {
            Bitmap = new Bitmap(_bitmapLocation.AbsolutePath);
            BitmapImage = new BitmapImage(_bitmapLocation);
            WriteableBitmap = new WriteableBitmap(BitmapImage);
        }

        public Bitmap Bitmap { get; private set; }
        public BitmapImage BitmapImage { get; private set; }
        public WriteableBitmap WriteableBitmap { get; private set; }
    }
}
