using Gym_TrackerJMAPI.Entities;
namespace GymTrackersAPI.Repositiories
{
    public interface IMembershipService
    {
        public Task<List<Membership>> MembershipGetAll(int apperal_id);
    }
}
