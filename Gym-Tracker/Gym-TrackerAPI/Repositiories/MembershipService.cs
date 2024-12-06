using Gym_TrackerAPI.Data;
using Gym_TrackerAPI.Entities;

namespace Gym_TrackerAPI.Repositiories
{
    //interface for MembershipService
    public class MembershipService : IMembershipService
    {

        public MembershipService(ApplicationDbContext dbContextClass)
        {
        }

        public Task<List<Membership>> MembershipLevelLength(int Membership_ID)
        {
            throw new NotImplementedException();
        }

        public Task<List<Membership>> MembershipLevelLength(string membershipLevel)
        {
            throw new NotImplementedException();
        }
    }

}