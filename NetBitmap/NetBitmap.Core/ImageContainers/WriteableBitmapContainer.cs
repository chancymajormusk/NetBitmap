using System.Drawing;
using System.Windows.Media.Imaging;
using NetBitmap.Core.ImageConverters;

namespace NetBitmap.Core.ImageContainers
{
    public class WriteableBitmapContainer : IImageContainer
    {
        public WriteableBitmapContainer(WriteableBitmap writeableBitmap)
        {
            WriteableBitmap = writeableBitmap;

            Initialize();
        }

        private void Initialize()
        {
            var writeableBitmapToBitmapConverter = new WriteableBitmapToBitmapConverter();
            var writeableBitmapToBitmapImageConverter = new WriteableBitmapToBitmapImageConverter();

            Bitmap = writeableBitmapToBitmapConverter.Convert(WriteableBitmap);
            BitmapImage = writeableBitmapToBitmapImageConverter.Convert(WriteableBitmap);
        }

        public Bitmap Bitmap { get; private set; }
        public BitmapImage BitmapImage { get; private set; }
        public WriteableBitmap WriteableBitmap { get; private set; }
    }
}
