using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Media.Imaging;

namespace NetBitmap.Core.Converters
{
    public class BitmapImageToBitmapConverter
    {
        /// <summary>
        /// Returns the System.Drawing.Bitmap equivalent of the passed in BitmapImage object.
        /// </summary>
        /// <param name="bitmapImage"></param>
        /// <returns></returns>
        public Bitmap Convert(BitmapImage bitmapImage)
        {
            Bitmap bitmap;

            using (var ms = new MemoryStream())
            {
                var encoder = new BmpBitmapEncoder();
                encoder.Frames.Add(BitmapFrame.Create(bitmapImage));
                encoder.Save(ms);

                using (var tmpBitmap = new Bitmap(ms))
                {
                    bitmap = tmpBitmap.Clone(new Rectangle(0, 0, tmpBitmap.Width, tmpBitmap.Height),
                                             PixelFormat.Format32bppArgb);
                }
            }

            return bitmap;
        }
    }
}
