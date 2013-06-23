using System.Drawing;
using System.Windows.Media.Imaging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NetBitmap.Core.Converters;

namespace NetBitmap.UnitTests.Core.ConverterTests
{
    public class ImageConverterTests : IConverterTests
    {
        private readonly Bitmap _bitmap;
        private readonly BitmapImage _bitmapImage;
        private readonly WriteableBitmap _writeableBitmap;

        public ImageConverterTests(Bitmap bitmap, BitmapImage bitmapImage, WriteableBitmap writeableBitmap)
        {
            _bitmap = bitmap;
            _bitmapImage = bitmapImage;
            _writeableBitmap = writeableBitmap;
        }

        public void BitmapImageToBitmapConversionSucceeds()
        {
            var bitmapImageToBitmapConverter = new BitmapImageToBitmapConverter();
            var bitmap = bitmapImageToBitmapConverter.Convert(_bitmapImage);

            Assert.IsTrue(bitmap != null);
        }

        public void BitmapImageToWriteableBitmapConversionSucceeds()
        {
            var bitmapImageToWriteableBitmapConverter = new BitmapImageToWriteableBitmapConverter();
            WriteableBitmap writeableBitmap = bitmapImageToWriteableBitmapConverter.Convert(_bitmapImage);

            Assert.IsTrue(writeableBitmap != null);
        }

        public void BitmapToBitmapImageConversionSucceeds()
        {
            var bitmapToBitmapImageConverter = new BitmapToBitmapImageConverter();
            BitmapImage bitmapImage = bitmapToBitmapImageConverter.Convert(_bitmap);

            Assert.IsTrue(bitmapImage != null);
        }

        public void BitmapToWriteableBitmapConversionSucceeds()
        {
            var bitmapToWriteableBitmapConverter = new BitmapToWriteableBitmapConverter();
            WriteableBitmap writeableBitmap = bitmapToWriteableBitmapConverter.Convert(_bitmap);

            Assert.IsTrue(writeableBitmap != null);
        }

        public void WriteableBitmapToBitmapConversionSucceeds()
        {
            var writeableBitmapToBitmapConverter = new WriteableBitmapToBitmapConverter();
            Bitmap bitmap = writeableBitmapToBitmapConverter.Convert(_writeableBitmap);

            Assert.IsTrue(bitmap != null);
        }

        public void WriteableBitmapToBitmapImageConversionSucceeds()
        {
            var writeableBitmapToBitmapImageConverter = new WriteableBitmapToBitmapImageConverter();
            BitmapImage bitmapImage = writeableBitmapToBitmapImageConverter.Convert(_writeableBitmap);

            Assert.IsTrue(bitmapImage != null);
        }
    }
}
