using GymTrackersAPI.Data;
using GymTrackersAPI.Entities;
using GymTrackersAPI.Repositiories;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;



namespace GymTrackersAPI.Repositiories
{
    public interface IExerciseService
    {
        Task<int> ExerciseAdd(ExtExercise exercise);
            
    }
}
