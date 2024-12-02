using Gym_TrackerAPI.Entities;
using Gym_TrackerAPI.Repositiories;
using Microsoft.AspNetCore.Mvc;

namespace Gym_TrackerAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]

    //Adding controller to the Course
    public class CourseController : ControllerBase
    {
        private readonly ICourseService CourseService;
        public CourseController(ICourseService CourseService)
        {
            this.CourseService = CourseService;
        }
        //asks for Class Price

        [HttpGet("{ClassPrice}")]
        public async Task<List<Course>> ClassP(int ClassPrice)
        {
            var CourseDetails = await CourseService.ClassP(ClassPrice);
            if (CourseDetails == null)
            {
            }
            return CourseDetails;


        }

    }
}