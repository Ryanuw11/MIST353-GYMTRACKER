using Gym_TrackerAPI.Entities;
namespace Gym_TrackerAPI.Repositiories;

public interface IApperalService
{
    public Task<List<Apperal>> ApperalGetAll(int apperal_id);
}
