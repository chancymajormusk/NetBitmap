using System.IO;
using System.Windows.Media.Imaging;

namespace NetBitmap.Core.ImageConverters
{
    public class WriteableBitmapToBitmapImageConverter
    {
        /// <summary>
        /// Returns the BitmapImage equivalent of the passed in WriteableBitmap object.
        /// </summary>
        /// <param name="writeableBitmap"></param>
        /// <returns></returns>
        public BitmapImage Convert(WriteableBitmap writeableBitmap)
        {
            BitmapImage finalBitmapImage;

            using (var ms = new MemoryStream())
            {
                var encoder = new JpegBitmapEncoder();
                encoder.Frames.Add(BitmapFrame.Create(writeableBitmap));

                encoder.Save(ms);

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
