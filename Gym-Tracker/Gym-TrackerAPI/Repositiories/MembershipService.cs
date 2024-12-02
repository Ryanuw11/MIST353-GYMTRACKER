using Gym_TrackerAPI.Entities;
using Gym_TrackerAPI.Data;

namespace Gym_TrackerAPI.Repositiories
{
    //interface for MembershipService
    public class MembershipService : IMembershipService
    {
        private readonly DbContextClass _dbContextClass;

        public MembershipService(DbContextClass dbContextClass)
        {
            _dbContextClass = dbContextClass;
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