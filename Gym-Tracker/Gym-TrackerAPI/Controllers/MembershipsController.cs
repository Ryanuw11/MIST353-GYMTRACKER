using Gym_TrackerJMAPI.Entities;
using GymTrackersAPI.Entities;
using GymTrackersAPI.Repositiories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

///Creating Membership Controller
namespace Gym_TrackerJMAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MembershipsController : ControllerBase
    {
        private readonly IMembershipService MembershipService;
        public MembershipsController(IMembershipService MembershipService)
        {
            this.MembershipService = MembershipService;
        }
        //asks for Membership ID

        [HttpGet("{Membership_ID}")]
        public async Task<List<Membership>> MembershipLevelLength(string MembershipLevel)
        {
            var MembershipDetails = await MembershipService.MembershipLevelLength(MembershipLevel);
            if (MembershipDetails == null)
            {
            }
            return MembershipDetails;


        }

    }
}