
using Gym_TrackerAPI.Entities;
using Gym_TrackerAPI.Repositiories;
using Microsoft.AspNetCore.Mvc;

namespace Gym_TrackerAPI.Controllers
{
    [Route("api[controller]")]
    [ApiController]
    public class LocationController : ControllerBase
    {
        private readonly ILocationMenu _LocationMenu;
        public LocationController(ILocationMenu LocationMenu)
        {
            _LocationMenu = LocationMenu;
        }
        [HttpGet("{gym_name}")]
        public async Task<ActionResult<List<GymLoc>>> GetGymLoc(string gym_name)
        {


            var LocationDetails = await _LocationMenu.LocationGetDetails(gym_name);
            return Ok(LocationDetails);
        }
    }
}
