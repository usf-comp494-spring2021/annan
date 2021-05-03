/// <summary>
/// Language:    C#
/// Author:      Anna Nguyen
/// Course:      COMP494 - C#
/// Date:        05/02/2021
/// Assignment:  Final
/// Purpose:     Model for the detailed weather forecast
/// </summary>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherForecastMVC.Models
{
    // Inherited from general weather forecast model
    public class WeatherForecastDetailsModel : WeatherForecastModel
    {
        public Int32 visibility { get; set; }
        public string clouds { get; set; }
        public Int32 humidity { get; set; }
        public double rainfall { get; set; }
        public double snowfall { get; set; }
    }
}