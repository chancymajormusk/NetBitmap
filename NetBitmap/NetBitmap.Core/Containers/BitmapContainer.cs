using System.Drawing;
using System.Windows.Media.Imaging;
using NetBitmap.Core.Converters;

namespace NetBitmap.Core.Containers
{
    public class BitmapContainer : IImageContainer
    {
        public BitmapContainer(Bitmap bitmap)
        {
            Bitmap = bitmap;

            Initialize();
        }

        private void Initialize()
        {
            var bitmapToBitmapImageConverter = new BitmapToBitmapImageConverter();
            var bitmapToWriteableBitmapConverter = new BitmapToWriteableBitmapConverter();

            BitmapImage = bitmapToBitmapImageConverter.Convert(Bitmap);
            WriteableBitmap = bitmapToWriteableBitmapConverter.Convert(Bitmap);
        }

        public Bitmap Bitmap { get; private set; }
        public BitmapImage BitmapImage { get; private set; }
        public WriteableBitmap WriteableBitmap { get; private set; }
    }
}
