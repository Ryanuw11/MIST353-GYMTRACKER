using Microsoft.AspNetCore.Mvc;

///Creating Membership Controller
namespace Gym_TrackerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MembershipsController : ControllerBase
    {

        string[] Level = { "Bronze", "Silver", "Gold" };


        [HttpGet]

        public IEnumerable<string> FetchSomething()
        {
            return Level;
        }
        //asks for Membership ID

        [HttpGet("{MembershipLevel}", Name = "Get")]

        public IActionResult Get(int MembershipLevel)
        {
            if (MembershipLevel >= 1 && MembershipLevel < Level.Length)
            {
                return Ok(Level[MembershipLevel]);
            }
            else if (MembershipLevel > Level.Length)
            {

                return NotFound("Not valid");
            }
            else
            {
                return BadRequest("Invalid ID");
            }


        }
    }
}