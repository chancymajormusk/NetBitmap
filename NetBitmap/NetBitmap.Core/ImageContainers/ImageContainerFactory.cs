using System;
using System.Drawing;
using System.Windows.Media.Imaging;

namespace NetBitmap.Core.ImageContainers
{
    public static class ImageContainerFactory
    {
        public static IImageContainer GetImageContainer(string imageLocation, UriKind pathFormat)
        {
            return new StringContainer(imageLocation, pathFormat);
        }

        public static IImageContainer GetImageContainer(Uri bitmapLocation)
        {
            return new StringContainer(bitmapLocation);
        }

        public static IImageContainer GetImageContainer(Bitmap bitmap)
        {
            return new BitmapContainer(bitmap);
        }

        public static IImageContainer GetImageContainer(BitmapImage bitmapImage)
        {
            return new BitmapImageContainer(bitmapImage);
        }

        public static IImageContainer GetImageContainer(WriteableBitmap writeableBitmap)
        {
            return new WriteableBitmapContainer(writeableBitmap);
        }
    }
}