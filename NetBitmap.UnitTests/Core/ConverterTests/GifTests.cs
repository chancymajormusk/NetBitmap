using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NetBitmap.UnitTests.Core.ConverterTests
{
    [TestClass]
    public class GifTests : IConverterTests
    {
        private readonly ImageConverterTests _imageConverterTests;

        public GifTests()
        {
            _imageConverterTests = new ConverterTestInitializer().Initialize(@"Core\ConverterTests\TestImages\testGif.gif");
        }

        [TestMethod]
        public void BitmapImageToBitmapConversionSucceeds()
        {
            _imageConverterTests.BitmapImageToBitmapConversionSucceeds();
        }

        [TestMethod]
        public void BitmapImageToWriteableBitmapConversionSucceeds()
        {
            _imageConverterTests.BitmapImageToWriteableBitmapConversionSucceeds();
        }

        [TestMethod]
        public void BitmapToBitmapImageConversionSucceeds()
        {
            _imageConverterTests.BitmapToBitmapImageConversionSucceeds();
        }

        [TestMethod]
        public void BitmapToWriteableBitmapConversionSucceeds()
        {
            _imageConverterTests.BitmapToWriteableBitmapConversionSucceeds();
        }

        [TestMethod]
        public void WriteableBitmapToBitmapConversionSucceeds()
        {
            _imageConverterTests.WriteableBitmapToBitmapConversionSucceeds();
        }

        [TestMethod]
        public void WriteableBitmapToBitmapImageConversionSucceeds()
        {
            _imageConverterTests.WriteableBitmapToBitmapImageConversionSucceeds();
        }
    }
}
