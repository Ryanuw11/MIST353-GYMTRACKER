using GymTrackersAPI.Entities;
namespace GymTrackersAPI.Repositiories;

public interface IApperalService
{
    public Task<List<Apperal>> ApperalGetAll(int apperal_id);
}
