using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Xml;
using Windows.UI.Xaml.Controls;
using System.Xml.Linq;
using Windows.UI.Xaml.Media.Imaging;


namespace Magic
{
    class FutureWeatherForecast
    {
        public async void getFutureWeatherForecast(TextBlock[] weatherText, Image[] weatherIcon)
        {
            try
            {

                Conditions[] futureConditions = new Conditions[8];  //create a new instance of condition class in order to update the properties

                WeatherIconClass IconClass = new WeatherIconClass();

                for (int i = 0; i < futureConditions.Length; i++)
                {
                    futureConditions[i] = new Conditions();
                }

                int DayCounter = 0;
                int MinCounter = 0;
                int MaxCounter = 0;
                int WindCounter = 0;
                int CloudCounter = 0;
                int PrecipCounter = 0;
                int ValueCounter = 0;
                int IconCounter = 0;

                string weburl = "http://api.openweathermap.org/data/2.5/forecast/daily?q=Wixom&mode=xml&units=imperial&cnt=8&appid=ee0dfc0c792f7b5673941a6f14a76724";//openweather plus my api key hardcoded for wixom

                var xml = await new HttpClient().GetStringAsync(weburl);

                XDocument xmlConditions = XDocument.Parse(xml);

                var DayQuery = from day in xmlConditions.Descendants("forecast").Elements("time").Attributes("day")
                               select day.Value;

                var TemperatureMinQuery = from tmin in xmlConditions.Descendants("forecast").Elements("time").Elements("temperature").Attributes("min")
                                          select tmin.Value;

                var TemperatureMaxQuery = from tmax in xmlConditions.Descendants("forecast").Elements("time").Elements("temperature").Attributes("max")
                                          select tmax.Value;

                var WindSpeedQuery = from ws in xmlConditions.Descendants("forecast").Elements("time").Elements("windSpeed").Attributes("name")
                                     select ws.Value;

                var CloudQuery = from c in xmlConditions.Descendants("forecast").Elements("time").Elements("clouds").Attributes("value")
                                 select c.Value;

                var PrecipitationQuery = from p in xmlConditions.Descendants("forecast").Elements("time").Elements("precipitation").Attributes("type")
                                         select p.Value;

                var WeatherValueQuery = from wv in xmlConditions.Descendants("forecast").Elements("time").Elements("symbol").Attributes("name")
                                        select wv.Value;

                var WeatherIconQuery = from wv in xmlConditions.Descendants("forecast").Elements("time").Elements("symbol").Attributes("var")
                                       select wv.Value;

                foreach (var c in DayQuery)
                {
                    futureConditions[DayCounter].Day = c;
                    DayCounter++;
                }

                foreach (var c in TemperatureMinQuery)
                {
                    futureConditions[MinCounter].TemperatureMin = c;
                    MinCounter++;
                }

                foreach (var c in TemperatureMaxQuery)
                {
                    futureConditions[MaxCounter].TemperatureMax = c;
                    MaxCounter++;
                }
                foreach (var c in WindSpeedQuery)
                {
                    futureConditions[WindCounter].WindName = c;
                    WindCounter++;
                }

                foreach (var c in CloudQuery)
                {
                    futureConditions[CloudCounter].CloudIntensity = c;
                    CloudCounter++;
                }

                foreach (var c in PrecipitationQuery)
                {
                    futureConditions[PrecipCounter].Precipitation = c;
                    PrecipCounter++;
                }

                foreach (var c in WeatherValueQuery)
                {
                    futureConditions[ValueCounter].WeatherValue = c;
                    ValueCounter++;
                }

                foreach (var c in WeatherIconQuery)
                {
                    futureConditions[IconCounter].WeatherIcon = c;
                    IconCounter++;
                }

                for (int i = 0; i < futureConditions.Length; i++)
                {
                    weatherText[i].Text = "Date: " + futureConditions[i].Day + Environment.NewLine + "High: " + futureConditions[i].TemperatureMax + Environment.NewLine + "Low: "
                        + futureConditions[i].TemperatureMin + Environment.NewLine + futureConditions[i].CloudIntensity + Environment.NewLine + futureConditions[i].Precipitation
                        + Environment.NewLine + futureConditions[i].WindName + Environment.NewLine + futureConditions[i].WeatherValue;
                }

                for (int i = 0; i < futureConditions.Length; i++)
                {
                    weatherIcon[i].Source = IconClass.weatherIconPng(futureConditions[i]);
                }
            }
            catch(HttpRequestException e)
            {
                weatherText[0].Text = "No internet Connection!";
                throw;
            }
        }
        }
}
