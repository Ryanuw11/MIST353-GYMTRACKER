using Gym_TrackerDKAPI.Data;

namespace Gym_TrackerDKAPI.Repositories
{
    public interface IApperalService
    {
        Task<IEnumerable<ExtApperal>> ApperalGetAll(int apperal_id);

    }
}
