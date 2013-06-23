using System.Drawing;
using System.Windows.Media.Imaging;

namespace NetBitmap.Core.ImageConverters
{
    public class WriteableBitmapToBitmapConverter
    {
        /// <summary>
        /// Returns the Bitmap equivalent of the passed in WriteableBitmap object.
        /// </summary>
        /// <param name="bitmap"></param>
        /// <returns></returns>
        public Bitmap Convert(WriteableBitmap writeableBitmap)
        {
            var writeableBitmapToBitmapImageConverter = new WriteableBitmapToBitmapImageConverter();
            var bitmapImageToBitmapConverter = new BitmapImageToBitmapConverter();

            var bitmapImage = writeableBitmapToBitmapImageConverter.Convert(writeableBitmap);
            return bitmapImageToBitmapConverter.Convert(bitmapImage);
        }
    }
}
