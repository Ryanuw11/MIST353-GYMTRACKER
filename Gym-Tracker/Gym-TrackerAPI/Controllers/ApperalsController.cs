using GymTrackersAPI.Repositiories;
using Microsoft.AspNetCore.Mvc;
using GymTrackersAPI.Entities;
using System.Linq.Expressions;

namespace GymTrackersAPI.Controllers
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
