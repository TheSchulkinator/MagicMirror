using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Windows.UI.Xaml.Controls;
using Windows.Data.Json;
using System.Xml.Linq;

namespace Magic
{
    class Weather
    {
        //Create an asynch method in order to get an xml file with the current weather conditions in order not to block the current thread.
        public async void getWeather(TextBlock weatherText, Image iconImage) {

            try { 

            Conditions conditions = new Conditions();  //create a new instance of condition class in order to update the properties

            WeatherIconClass currentIcon = new WeatherIconClass();

            //TODO:Add API KEY after equal in url

            string weburl = "http://api.openweathermap.org/data/2.5/weather?zip=48393,us&mode=xml&units=imperial&appid=";//openweather plus my api key hardcoded for wixom

            var xml = await new HttpClient().GetStringAsync(weburl);

            XDocument xmlConditions = XDocument.Parse(xml);

            var currentConditions = from c in xmlConditions.Descendants("current")
                                    select new
                                    {
                                        CityName = c.Element("city").Attribute("name").Value,
                                        Temperature = c.Element("temperature").Attribute("value").Value,  //in kelvin
                                        WindSpeedValue = c.Element("wind").Element("speed").Attribute("value").Value,
                                        WindSpeedName = c.Element("wind").Element("speed").Attribute("name").Value,
                                        CloudName = c.Element("clouds").Attribute("name").Value,
                                        PrecipitationMode = c.Element("precipitation").Attribute("mode").Value,
                                        WeatherValue = c.Element("weather").Attribute("value").Value,
                                        WeatherIcon = c.Element("weather").Attribute("icon").Value,
                                    };
            foreach (var r in currentConditions)
            {
                conditions.CityName = r.CityName;
                conditions.Temperature = r.Temperature;
                conditions.WindSpeed = r.WindSpeedValue;
                conditions.WindName = r.WindSpeedName;
                conditions.CloudIntensity = r.CloudName;
                conditions.Precipitation = r.PrecipitationMode;
                conditions.WeatherValue = r.WeatherValue;
                conditions.WeatherIcon = r.WeatherIcon;
            }


                weatherText.Text = conditions.CityName + Environment.NewLine + "Temperature: " + conditions.Temperature + "F" +
                    Environment.NewLine + conditions.WindName + Environment.NewLine + conditions.WeatherValue;

                iconImage.Source = currentIcon.weatherIconPng(conditions);
        }
            catch (HttpRequestException x)
            {
                weatherText.Text = "No internet connection!";
            }
        }


    }
}
