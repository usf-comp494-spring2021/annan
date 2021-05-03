/// <summary>
/// Language:    C#
/// Author:      Anna Nguyen
/// Course:      COMP494 - C#
/// Date:        05/02/2021
/// Assignment:  Final
/// Purpose:     Model for the hourly weather forecast
/// </summary>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherForecastMVC.Models
{
    // Inherited from the general weather forecast model
    public class WeatherForecastHourlyModel:WeatherForecastModel
    {
        public Int32 precipitationPercent { get; set; }
        public double precipitationAmount { get; set; }
        public Int32 cloudCover { get; set; }
        public Int32 dewPoint { get; set; }
        public Int32 humidity { get; set; }
    }
}