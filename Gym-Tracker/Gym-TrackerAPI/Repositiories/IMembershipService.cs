using GymTrackersAPI.Entities;
namespace GymTrackersAPI.Repositiories
{
    public interface IMembershipService
    {
        public Task<List<Membership>> MembershipLevelLength(int Membership_ID);
        Task<List<Membership>> MembershipLevelLength(string membershipLevel);
    }
}
