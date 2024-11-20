using Gym_TrackerJMAPI.Entities;
using GymTrackersAPI.Entities;
using GymTrackersAPI.Repositiories;
using Microsoft.AspNetCore.Http;
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
            return Level;3
        }
        //asks for Membership ID

        [HttpGet("{MembershipID}", Name = "Get")]

        public IActionResult Get(int MembershipID)
        {
            if (MembershipID >= 1 && MembershipID <Level.Length)
            {
                return Ok(Level[MembershipID]);
            }
            else if (MembershipID > Level.Length)
            {

                return NotFound("Not valid");
            }
            else
            {
                return BadRequest("Invalid ID");
            }


        } }}