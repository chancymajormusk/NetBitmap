using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Media.Imaging;

namespace NetBitmap.Core.Converters
{
    public class BitmapToBitmapImageConverter
    {
        /// <summary>
        /// Returns the BitmapImage equivalent of the passed in Bitmap object.
        /// </summary>
        /// <param name="bitmap"></param>
        /// <returns></returns>
        public BitmapImage Convert(Bitmap bitmap)
        {
            BitmapImage finalBitmapImage;

            using (var ms = new MemoryStream())
            {
                bitmap.Save(ms, ImageFormat.Bmp);

                ms.Position = 0;

                var bitmapImage = new BitmapImage();

                bitmapImage.BeginInit();
                bitmapImage.StreamSource = ms;
                bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
                bitmapImage.EndInit();
                bitmapImage.Freeze();

                finalBitmapImage = bitmapImage.Clone();
            }

            return finalBitmapImage;
        }
    }
}
