using Gym_TrackerAPI.Data;
using Gym_TrackerAPI.Entities;
using Gym_TrackerAPI.Repositiories;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;



namespace Gym_TrackerAPI.Repositiories
{
    public interface IExerciseService
    {
        Task<int> ExerciseAdd(ExtExercise exercise);
            
    }
}
