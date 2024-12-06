using Gym_TrackerAPI.Data;
using Gym_TrackerAPI.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;


namespace Gym_TrackerAPI.Repositiories
{
    public class GymMenu : IGymMenu
    {
        private readonly ApplicationDbContext _dbContextClass;
        public GymMenu(ApplicationDbContext dbContextClass)
        {
            _dbContextClass = dbContextClass;
        }

        public async Task<List<UserData>> GymGetDetails(int id)
        {
            var param = new SqlParameter("@id", id);
            var gymDetails = await _dbContextClass.UserData.FromSqlRaw("exec spUserLookup @id", param).ToListAsync();
            return gymDetails;
        }
    }
}
