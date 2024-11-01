using GymTrackersAPI.Repositiories;
using Microsoft.AspNetCore.Mvc;
using GymTrackersAPI.Entities;
using System.Linq.Expressions;
using GymTrackersAPI.Data;

namespace GymTrackersAPI.Controllers
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

