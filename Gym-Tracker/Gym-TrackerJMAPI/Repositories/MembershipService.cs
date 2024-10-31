using Gym_TrackerJMAPI.Data;

namespace Gym_TrackerJMAPI.Repositories
{ 

    public class MembershipService : IApperalService
{
    private readonly DbContextClass _dbContextClass;
    public MembershipService(DbContextClass dbContextClass)
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
}