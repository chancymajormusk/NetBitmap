using System.Drawing;
using System.Windows.Media.Imaging;

namespace NetBitmap.Core.Containers
{
    public interface IImageContainer
    {
        Bitmap Bitmap { get; }
        BitmapImage BitmapImage { get; }
        WriteableBitmap WriteableBitmap { get; }
    }
}