using Gym_TrackerDKAPI.Data;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Gym_TrackerDKAPI.Entities;

namespace Gym_TrackerDKAPI.Repositories
{
    public interface IExerciseService
    {
        Task<int> ExerciseAdd(ExtExercise exercise);
            
    }
}
