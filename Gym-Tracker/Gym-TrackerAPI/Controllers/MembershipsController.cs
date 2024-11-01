using GymTrackersAPI.Repositiories;
using Microsoft.AspNetCore.Mvc;
using GymTrackersAPI.Entities;
using System.Linq.Expressions;

namespace GymTrackersAPI.Controllers
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