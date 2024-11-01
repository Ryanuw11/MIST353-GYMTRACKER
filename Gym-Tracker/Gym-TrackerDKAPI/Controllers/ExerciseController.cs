using Gym_TrackerDKAPI.Repositories;
using Gym_TrackerDKAPI.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Gym_TrackerDKAPI.Controllers
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

