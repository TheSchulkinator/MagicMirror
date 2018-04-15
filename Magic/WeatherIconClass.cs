using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media.Imaging;

namespace Magic
{
    class WeatherIconClass
    {
        //create a method that takes a condition instance and returns a bitmap back that reflects the type of weatherIcon associated with it

        public BitmapImage weatherIconPng(Conditions conditionIcon)
        {
            BitmapImage weatherBitmap;

            switch (conditionIcon.WeatherIcon)
            {
                case "01d":
                    weatherBitmap = new BitmapImage(new Uri("ms-appx:///Assets/Icon/01d.png"));
                    break;
                case "01n":
                    weatherBitmap = new BitmapImage(new Uri("ms-appx:///Assets/Icon/01n.png"));
                    break;
                case "02d":
                    weatherBitmap = new BitmapImage(new Uri("ms-appx:///Assets/Icon/02d.png"));
                    break;
                case "02n":
                    weatherBitmap = new BitmapImage(new Uri("ms-appx:///Assets/Icon/02n.png"));
                    break;
                case "03d":
                    weatherBitmap = new BitmapImage(new Uri("ms-appx:///Assets/Icon/03d.png"));
                    break;
                case "03n":
                    weatherBitmap = new BitmapImage(new Uri("ms-appx:///Assets/Icon/03n.png"));
                    break;
                case "04d":
                    weatherBitmap = new BitmapImage(new Uri("ms-appx:///Assets/Icon/04d.png"));
                    break;
                case "04n":
                    weatherBitmap = new BitmapImage(new Uri("ms-appx:///Assets/Icon/04n.png"));
                    break;
                case "09d":
                    weatherBitmap = new BitmapImage(new Uri("ms-appx:///Assets/Icon/09d.png"));
                    break;
                case "09n":
                    weatherBitmap = new BitmapImage(new Uri("ms-appx:///Assets/Icon/09n.png"));
                    break;
                case "10d":
                    weatherBitmap = new BitmapImage(new Uri("ms-appx:///Assets/Icon/10d.png"));
                    break;
                case "10n":
                    weatherBitmap = new BitmapImage(new Uri("ms-appx:///Assets/Icon/10n.png"));
                    break;
                case "11d":
                    weatherBitmap = new BitmapImage(new Uri("ms-appx:///Assets/Icon/11d.png"));
                    break;
                case "11n":
                    weatherBitmap = new BitmapImage(new Uri("ms-appx:///Assets/Icon/11n.png"));
                    break;
                case "13d":
                    weatherBitmap = new BitmapImage(new Uri("ms-appx:///Assets/Icon/13d.png"));
                    break;
                case "13n":
                    weatherBitmap = new BitmapImage(new Uri("ms-appx:///Assets/Icon/13n.png"));
                    break;
                case "50d":
                    weatherBitmap = new BitmapImage(new Uri("ms-appx:///Assets/Icon/50d.png"));
                    break;
                case "50n":
                    weatherBitmap = new BitmapImage(new Uri("ms-appx:///Assets/Icon/50n.png"));
                    break;
                default:
                    weatherBitmap = new BitmapImage(new Uri("ms-appx:///Assets/Icon/error.png"));
                    break;
            }

            return weatherBitmap;
        }
    }
}
