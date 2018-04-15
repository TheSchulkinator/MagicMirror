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
    class BackgroundImage
    {
        public static void BackgroundImageSwitch(Image backgroundImage, Storyboard entrance, Storyboard exit)
        {
            switch (MainPage.speechResult)
            {
                case "hashtag relationship goals":
                    entrance.Begin();
                    backgroundImage.Source = new BitmapImage(new Uri("ms-appx:///Assets/Background/goals.jpg"));
                    break;
                case "he who must not be named":
                    entrance.Begin();
                    backgroundImage.Source = new BitmapImage(new Uri("ms-appx:///Assets/Background/voldermort.jpg"));
                    break;
                default:
                    backgroundImage.Source = new BitmapImage(new Uri("ms-appx:///Assets/Icon/error.png"));
                    break;
            }
        }
    }
}
