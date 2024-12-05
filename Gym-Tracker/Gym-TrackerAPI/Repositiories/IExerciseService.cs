using Gym_TrackerAPI.Data;



namespace Gym_TrackerAPI.Repositiories
{
    public interface IExerciseService
    {
        Task<int> ExerciseAdd(ExtExercise exercise);

    }
}
