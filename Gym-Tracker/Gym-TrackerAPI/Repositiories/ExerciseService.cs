using GymTrackersAPI.Data;
using GymTrackersAPI.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
namespace GymTrackersAPI.Repositiories
{
    public class ExerciseService : IExerciseService
    {
        private readonly DbContextClass _dbContext;
        //this is a method for the user to input the name,equipment, and muscletarget of a new exercise they wish to input
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
