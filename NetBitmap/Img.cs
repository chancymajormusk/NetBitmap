using System;
using System.Drawing;
using System.Windows.Media.Imaging;
using NetBitmap.Core.ImageContainers;

namespace NetBitmap
{
    public class Img
    {
        private readonly IImageContainer _imageContainer;

        public Img(string imageLocation, UriKind uriKind)
        {
            _imageContainer = ImageContainerFactory.GetImageContainer(imageLocation, uriKind);
        }

        public Img(Uri imageLocation)
        {
            _imageContainer = ImageContainerFactory.GetImageContainer(imageLocation);
        }

        public Img(Bitmap bitmap)
        {
            _imageContainer = ImageContainerFactory.GetImageContainer(bitmap);
        }

        public Img(BitmapImage bitmapImage)
        {
            _imageContainer = ImageContainerFactory.GetImageContainer(bitmapImage);
        }

        public Img(WriteableBitmap writeableBitmap)
        {
            _imageContainer = ImageContainerFactory.GetImageContainer(writeableBitmap);
        }

        public Bitmap Bitmap
        {
            get
            {
                return _imageContainer.Bitmap;
            }
        }

        public BitmapImage BitmapImage
        {
            get
            {
                return _imageContainer.BitmapImage;
            }
        }

        public WriteableBitmap WriteableBitmap
        {
            get
            {
                return _imageContainer.WriteableBitmap;
            }
        }
    }
}
