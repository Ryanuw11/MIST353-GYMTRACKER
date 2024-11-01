using Gym_TrackerDKAPI.Data;
using Gym_TrackerDKAPI.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace Gym_TrackerDKAPI.Repositories
{
    public class ExerciseService : IExerciseService
    {
        private readonly DbContextClass _dbContext;
        public ExerciseService(DbContextClass dbContext)
        {
            _dbContext = dbContext;
        }
  
             public async Task<int> ExerciseAdd(ExtExercise exercise)
        {
            var parameter = new List<SqlParameter>();
            parameter.Add(new SqlParameter("@Name", exercise.Name));
            parameter.Add(new SqlParameter("@Equipment", exercise.Equipment));
            parameter.Add(new SqlParameter("@MuscleTarget", exercise.MuscleTarget));
        
            return await _dbContext.Database.ExecuteSqlRawAsync("exec spExerciseAdd @Name, @Equipment, @MuscleTarget", parameter.ToArray());
        }
    }
}
