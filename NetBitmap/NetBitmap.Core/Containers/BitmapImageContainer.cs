using System.Drawing;
using System.Windows.Media.Imaging;
using NetBitmap.Core.Converters;

namespace NetBitmap.Core.Containers
{
    public class BitmapImageContainer : IImageContainer
    {
        public BitmapImageContainer(BitmapImage bitmapImage)
        {
            BitmapImage = bitmapImage;

            Initialize();
        }

        private void Initialize()
        {
            var bitmapImageToBitmapConverter = new BitmapImageToBitmapConverter();
            var bitmapImageToWriteableBitmapConverter = new BitmapImageToWriteableBitmapConverter();

            Bitmap = bitmapImageToBitmapConverter.Convert(BitmapImage);
            WriteableBitmap = bitmapImageToWriteableBitmapConverter.Convert(BitmapImage);
        }

        public Bitmap Bitmap { get; private set; }
        public BitmapImage BitmapImage { get; private set; }
        public WriteableBitmap WriteableBitmap { get; private set; }
    }
}
