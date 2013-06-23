using System.Drawing;
using System.Windows.Media.Imaging;

namespace NetBitmap.Core.Converters
{
    public class BitmapToWriteableBitmapConverter
    {
        /// <summary>
        /// Returns the WriteableBitmap equivalent of the passed in Bitmap object.
        /// </summary>
        /// <param name="bitmap"></param>
        /// <returns></returns>
        public WriteableBitmap Convert(Bitmap bitmap)
        {
            var bitmapToBitmapImageConverter = new BitmapToBitmapImageConverter();
            var bitmapImageToWriteableBitmapConverter = new BitmapImageToWriteableBitmapConverter();

            var bitmapImage = bitmapToBitmapImageConverter.Convert(bitmap);
            return bitmapImageToWriteableBitmapConverter.Convert(bitmapImage);
        }
    }
}
