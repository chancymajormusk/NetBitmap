using System.Windows.Media.Imaging;

namespace NetBitmap.Core.Converters
{
    public class BitmapImageToWriteableBitmapConverter
    {
        /// <summary>
        /// Returns the WriteableBitmap equivalent of the passed in BitmapImage object.
        /// </summary>
        /// <param name="bitmapImage"></param>
        /// <returns></returns>
        public WriteableBitmap Convert(BitmapImage bitmapImage)
        {
            return new WriteableBitmap(bitmapImage.Clone());
        }
    }
}
