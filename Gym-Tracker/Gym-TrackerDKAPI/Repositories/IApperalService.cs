using Gym_TrackerDKAPI.Entities;

namespace Gym_TrackerDKAPI.Repositories
{
    public interface IApperalService
    {
        public Task<List<Apperal>> ApperalGetAll(int apperal_id);
    }
}
