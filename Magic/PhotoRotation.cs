using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Media.Imaging;

namespace Magic
{
    class PhotoRotation
    {
        public async static void RotateImageGallery(Image currentImage, Storyboard beginStory, Storyboard endStory)
        {
            while (MainPage.speechResult == "Britters and Greggers")
            {
                for (int i = 0; i < 84; i++)
                {
                    string photoDestination = "ms-appx:///Assets/Engagement/0 (" + i + ").jpg";
                    beginStory.Begin();
                    currentImage.Source = new BitmapImage(new Uri(photoDestination));
                    await Task.Delay(90000);
                    endStory.Begin();
                    await Task.Delay(10000);
                }
            }
        }
    }
}
