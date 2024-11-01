using Gym_TrackerJMAPI.Entities;

namespace GymTrackersAPI.Repositiories
{
    public interface ICourseService
    {
        public Task<List<Course>> ClassP(int @ClassPrice);
    }
}
