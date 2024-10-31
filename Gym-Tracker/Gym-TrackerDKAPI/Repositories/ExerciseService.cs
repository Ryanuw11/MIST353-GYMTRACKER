using Gym_TrackerDKAPI.Data;
using Gym_TrackerDKAPI.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;


namespace Gym_TrackerDKAPI.Repositories
{
    public class ExerciseService : IExerciseService
    {
        private readonly DbContextClass _dbContextClass;
        public ExerciseService(DbContextClass dbContextClass)
        {
            _dbContextClass = dbContextClass;
        }
        public async Task<List<Exercise>> ExerciseAdd();
        {
        var param = new SqlParameter("@exercise_name", exercise_name);
    }
}
