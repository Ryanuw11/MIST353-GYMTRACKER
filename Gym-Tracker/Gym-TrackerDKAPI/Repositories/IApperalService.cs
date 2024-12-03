using Gym_TrackerDKAPI.Data;
using Gym_TrackerDKAPI.Entities;

namespace Gym_TrackerDKAPI.Repositories
{
    public interface IApperalService
    {
        Task<IEnumerable<ExtApperal>> ApperalGetAll(int apperal_id);
      
    }
}
