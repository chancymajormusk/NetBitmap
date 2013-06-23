namespace NetBitmap.UnitTests.Core.ConverterTests
{
    public interface IConverterTests
    {
        void BitmapImageToBitmapConversionSucceeds();

        void BitmapImageToWriteableBitmapConversionSucceeds();

        void BitmapToBitmapImageConversionSucceeds();

        void BitmapToWriteableBitmapConversionSucceeds();

        void WriteableBitmapToBitmapConversionSucceeds();

        void WriteableBitmapToBitmapImageConversionSucceeds();
    }
}