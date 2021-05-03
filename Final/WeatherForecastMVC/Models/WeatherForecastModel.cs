/// <summary>
/// Language:    C#
/// Author:      Anna Nguyen
/// Course:      COMP494 - C#
/// Date:        05/02/2021
/// Assignment:  Final
/// Purpose:     Model for the general weather forecast
/// </summary>

using System;

namespace WeatherForecastMVC.Models
{
    public class WeatherForecastModel
    {
        public DateTime forecastDate { get; set; }
        public string location { get; set; }
        public double temperature { get; set; }
        public double feelsLike { get; set; }
        public string descriptor { get; set; }
        // wave, wind, flash, frost, cloud, sun, sunset, drop
        public string imagePath { get; set; }
        public double windSpeed { get; set; }
        public string windDirection { get; set; }
        public double pressure { get; set; }
    }
}