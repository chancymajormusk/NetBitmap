using System.Drawing;
using System.Windows.Media.Imaging;

namespace NetBitmap.Core.ImageContainers
{
    /// <summary>
    /// Any class implementing the IImageContainer needs to contain a System.Drawing.Bitmap image, a BitmapImage image and a WriteableBitmap image
    /// </summary>
    public interface IImageContainer
    {
        Bitmap Bitmap { get; }
        BitmapImage BitmapImage { get; }
        WriteableBitmap WriteableBitmap { get; }
    }
}