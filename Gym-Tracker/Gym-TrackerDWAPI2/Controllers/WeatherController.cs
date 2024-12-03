using Gym_TrackerDWAPI.Entities;
using Gym_TrackerDWAPI.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Gym_TrackerDWAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeatherController : ControllerBase
    {
        private readonly IWeatherRepository weatherRepository;

        public WeatherController(IWeatherRepository weatherRepository)
        {
            this.weatherRepository = weatherRepository;
        }

        public IWeatherRepository GetWeatherRepository()
        {
            return weatherRepository;
        }

        [HttpGet("WeatherData")]
        public async Task<ActionResult<List<WeatherData>>> GetWeatherData(DateTime date, IWeatherRepository weatherRepository)
        {
           // var weatherData = await weatherRepository.GetWeatherData(date);
            //if (weatherData == null )
            {
                return NotFound();
            }
          //  return Ok(weatherData);
        }
    }
}
