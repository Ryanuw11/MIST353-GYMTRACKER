using GymTrackersAPI.Repositiories;
using Microsoft.AspNetCore.Mvc;
using GymTrackersAPI.Entities;

namespace GymTrackersAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GymController : Controller
    {
        private readonly IGymMenu gymMenu;
        public GymController(IGymMenu gymMenu)
        {

            this.gymMenu = gymMenu;
        }
        [HttpGet("{id}")]

        public async Task<List<UserData>> GetUserDatas(int id)
        {
        var gymDetails = await gymMenu.GymGetDetails(id);
        if (gymDetails == null)
            {
               //return NotFound();
            }
            return gymDetails;
        }
    }
}
