using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Gym_TrackerJMAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MembershipsController : ControllerBase
    {
        [HttpGet]
        public ActionResult MembershipLevels()
        {
            string[] Membership = { "Bronze", "Silver", "Gold" };

            if (Membership.Length < 0)
                return NotFound();
            return Ok(Membership);
            
            
     
        }
    } }
