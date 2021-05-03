/// <summary>
/// Language:    C#
/// Author:      Anna Nguyen
/// Course:      COMP494 - C#
/// Date:        05/02/2021
/// Assignment:  Final
/// Purpose:     This will control the Web MVC's interaction with the live API
/// </summary>
/// 
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Json;

using WeatherForecastMVC.Models;

namespace WeatherForecastMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IHttpClientFactory clientFactory;

        public HomeController(ILogger<HomeController> logger, IHttpClientFactory httpClientFactory)
        {
            _logger = logger;
            clientFactory = httpClientFactory;
        }

        // This is the controller for the general weather forecast
        [HttpGet]
        [ProducesResponseType(200,
          Type = typeof(WeatherForecastModel))]
        public async Task<IActionResult> WeatherForecast()
        {
            string uri = "WeatherForecast";

            var client = clientFactory.CreateClient(
                name: "WeatherForecast");


            var request = new HttpRequestMessage(
                method: HttpMethod.Get, requestUri: uri);

            HttpResponseMessage response = await client.SendAsync(request);

            var model = await response.Content.ReadFromJsonAsync<WeatherForecastModel>();

            return View(model);
        }

        // This is the controller for the detailed weather forecast
        [HttpGet]
        [ProducesResponseType(200,
          Type = typeof(WeatherForecastDetailsModel))]
        public async Task<IActionResult> WeatherForecastDetails()
        {
            string uri = "WeatherForecast/details";

            var client = clientFactory.CreateClient(
                name: "WeatherForecast");


            var request = new HttpRequestMessage(
                method: HttpMethod.Get, requestUri: uri);

            HttpResponseMessage response = await client.SendAsync(request);

            var model = await response.Content.ReadFromJsonAsync<WeatherForecastDetailsModel>();

            return View(model);
        }

        // This is the controller for the hourly weather forecast
        [HttpGet]
        [ProducesResponseType(200,
         Type = typeof(IEnumerable<WeatherForecastHourlyModel>))]
        public async Task<IActionResult> WeatherForecastHourly()
        {
            string uri = "WeatherForecast/hourly";

            var client = clientFactory.CreateClient(
                name: "WeatherForecast");


            var request = new HttpRequestMessage(
                method: HttpMethod.Get, requestUri: uri);

            HttpResponseMessage response = await client.SendAsync(request);

            var model = await response.Content.ReadFromJsonAsync<IEnumerable<WeatherForecastHourlyModel>>();

            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
