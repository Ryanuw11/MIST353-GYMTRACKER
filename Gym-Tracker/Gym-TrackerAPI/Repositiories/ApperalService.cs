using GymTrackersAPI.Entities;
using GymTrackersAPI.Data;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace GymTrackersAPI.Repositiories;
public class ApperalService : IApperalService
{
    private readonly DbContextClass _dbContextClass;
    public ApperalService(DbContextClass dbContextClass)
    {
        _dbContextClass = dbContextClass;
    }
    public async Task<List<Apperal>> ApperalGetAll(int apperal_id)
    {
        var param = new SqlParameter("@apperal_id", apperal_id);
        var apperalDetails = await Task.Run(() => _dbContextClass.Apperal.FromSqlRaw("exec spApperalGetAll@apperal_id", param).ToListAsync());
        return apperalDetails;
    }
}