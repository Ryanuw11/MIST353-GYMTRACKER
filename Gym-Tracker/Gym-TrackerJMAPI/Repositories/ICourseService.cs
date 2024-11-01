using Gym_TrackerJMAPI.Entities;
//Course Service Interface

namespace GymTrackersAPI.Repositiories
{
    public interface ICourseService
    {
        public Task<List<Course>> ClassP(int @ClassPrice);
    }
}
