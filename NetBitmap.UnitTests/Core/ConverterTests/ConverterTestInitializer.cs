using System;
using System.Drawing;
using System.IO;
using System.Windows.Media.Imaging;

namespace NetBitmap.UnitTests.Core.ConverterTests
{
    public class ConverterTestInitializer
    {
        public ImageConverterTests Initialize(string imageUrl)
        {
            const string tmpPath = @"C:\temp";

            var tmpPathExists = Directory.Exists(tmpPath);

            if (!tmpPathExists)
            {
                Directory.CreateDirectory(tmpPath);
            }

            var bitmap = new Bitmap(imageUrl);
            var bitmapImage = new BitmapImage(new Uri(imageUrl, UriKind.Relative));
            var writeableBitmap = new WriteableBitmap(new BitmapImage(new Uri(imageUrl, UriKind.Relative)));

            var imageConverterTests = new ImageConverterTests(bitmap, bitmapImage, writeableBitmap);
            return imageConverterTests;
        }
    }
}
