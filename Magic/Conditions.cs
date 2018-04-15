using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic
{
    class Conditions
    {
        //set a class with variables to store the data pulled in from OpenWeather

        string day = "No Data";
        string sunRise = "No Data";  
        string sunSet = "No Data";
        string cityName = "No Data";
        string temperature = "No Data";
        string temperatureMin = "No Data";
        string temperatureMax = "No Data";
        string windSpeed = "No Data";
        string windName = "No Data";
        string cloudIntensity = "No Data";
        string precepitation = "No Data";
        string weatherValue = "No Data";
        string weatherIcon = "No Data";  //A string that will associate with a PNG file to show a picture of weather http://openweathermap.org/weather-conditions
        int weatherNumber = 0; //A code provided by OPENWEATHER that associates with a certain weather condition http://openweathermap.org/weather-conditions


        //set up properties to access the private values of the class 
        public string Day
        {
            get { return day; }
            set { day = value; }
        }


        public string SunRise
        {
            get { return sunRise; }
            set { sunRise = value;}
        }

        public string SunSet
        {
            get { return sunSet; }
            set { sunSet = value; }
        }

        public string CityName
        {
            get { return cityName; }
            set { cityName = value; }
        }

        public string Temperature
        {
            get { return temperature; }
            set { temperature = value; }
        }

        public string TemperatureMin
        {
            get { return temperatureMin; }
            set { temperatureMin = value; }
        }

        public string TemperatureMax
        {
            get { return temperatureMax; }
            set { temperatureMax = value; }
        }

        public string WindSpeed
        {
            get { return windSpeed; }
            set { windSpeed = value; }
        }

        public string WindName
        {
            get { return windName; }
            set { windName = value; }
        }

        public string CloudIntensity
        {
            get { return cloudIntensity; }
            set { cloudIntensity = value; }
        }

        public string Precipitation
        {
            get { return precepitation; }
            set { precepitation = value; }
        }

        public string WeatherValue
        {
            get { return weatherValue;}
            set { weatherValue = value;}
        }

        public string WeatherIcon
        {
            get { return weatherIcon; }
            set { weatherIcon = value; }
        }

        public int WeatherNumber
        {
            get { return weatherNumber; }
            set { weatherNumber = value; }
        }
    }
}
