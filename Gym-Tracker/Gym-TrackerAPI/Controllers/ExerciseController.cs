using Gym_TrackerAPI.Data;
using Gym_TrackerAPI.Repositiories;
using Microsoft.AspNetCore.Mvc;

namespace Gym_TrackerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExerciseController : ControllerBase
    {
        private readonly IExerciseService ExerciseService;
        public ExerciseController(IExerciseService exerciseService)
        {
            this.ExerciseService = exerciseService;
        }
        [HttpPost("addexercise")]
        public async Task<IActionResult> ExerciseAddAsync(ExtExercise exercise)
        {
            if (exercise == null)
            {
                return BadRequest();
            }
            try
            {
                var response = await ExerciseService.ExerciseAdd(exercise);
                return Ok(response);
            }
            catch
            {
                throw;
            }
        }
    }
}

