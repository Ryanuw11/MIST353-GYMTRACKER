using Gym_TrackerDKAPI.Entities;
using Gym_TrackerDKAPI.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Gym_TrackerDKAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApperalsController : Controller
    {
        private readonly IApperalService apperalService;
        public ApperalsController(IApperalService apperalService)
        {
            this.apperalService = apperalService;
        }
        [HttpGet("{Apperal_id}")]
        public async Task<List<Apperal>> ApperalGetAll(int apperal_id);
        {
            var apperalDetails = await ApperalService.ApperalGetAll(apperal_id);
            if apperalDetails == null)
            {
                return NotFound();
            }
            return apperalDetails;
        
    
    }

    }
}
