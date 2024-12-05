using Gym_TrackerAPI.Entities;
using Gym_TrackerAPI.Repositiories;
using Microsoft.AspNetCore.Mvc;

namespace Gym_TrackerAPI.Controllers
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
        public async Task<List<Apperal>> ApperalGetAll(int apperal_id)
        {
            var apperalDetails = await apperalService.ApperalGetAll(apperal_id);
            if (apperalDetails == null)
            {
                // return NotFound();
            }
            return apperalDetails;


        }

    }
}
