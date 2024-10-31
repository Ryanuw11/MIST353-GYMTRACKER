using Gym_TrackerDKAPI.Entities;

namespace Gym_TrackerDKAPI.Repositories
{
    public interface IExerciseService
    {
        public async Task<List<Exercise>> ExerciseAdd();
    }
}
