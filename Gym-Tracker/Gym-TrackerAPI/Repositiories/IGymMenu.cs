using Gym_TrackerAPI.Entities;
namespace Gym_TrackerAPI.Repositiories
{
    public interface IGymMenu
    {
        public Task<List<UserData>> GymGetDetails(int id);
    }
}
