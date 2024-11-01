using GymTrackersAPI.Entities;
namespace GymTrackersAPI.Repositiories
{
    public interface ILocationMenu
    {
        public Task<List<GymLoc>> LocationGetDetails(string gym_name);
    }
}
