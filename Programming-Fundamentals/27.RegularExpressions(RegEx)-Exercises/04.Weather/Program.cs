using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Weather
{
    public class Weather
    {
        public double Temperature { get; set; }

        public string WeatherType { get; set; }
    }

    class WeatherInCity
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine();
            var pattern = @"(?<city>[A-Z]{2})(?<temp>\d+.\d+)(?<weatherType>[A-Za-z]+)\|";
            Dictionary<string, Weather> cityWeather = new Dictionary<string, Weather>();
            Regex regex = new Regex(pattern);

            while (inputLine != "end")
            {
                var isInputValid = regex.IsMatch(inputLine);

                if (!isInputValid)
                {
                    inputLine = Console.ReadLine();
                    continue;
                }

                Match cityWeatherMatch = regex.Match(inputLine);

                var city = cityWeatherMatch.Groups["city"].Value;
                var temp = double.Parse(cityWeatherMatch.Groups["temp"].Value);
                var weatherType = cityWeatherMatch.Groups["weatherType"].Value;
                Weather currentWeather = new Weather
                {
                    Temperature = temp,
                    WeatherType = weatherType
                };

                cityWeather[city] = currentWeather;
                inputLine = Console.ReadLine();
            }

            var orderedCityByTemp = cityWeather.OrderBy(c => c.Value.Temperature).ToDictionary(c => c.Key, c => c.Value);

            foreach (var city in orderedCityByTemp)
            {
                var cityCode = city.Key;
                var temperature = city.Value.Temperature;
                var weather = city.Value.WeatherType;
                Console.WriteLine($"{cityCode} => {temperature:F2} => {weather}");
            }
        }
    }
}
