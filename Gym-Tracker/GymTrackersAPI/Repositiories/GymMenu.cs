using GymTrackersAPI.Data;
using GymTrackersAPI.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;


namespace GymTrackersAPI.Repositiories
{
    public class GymMenu : IGymMenu
    {
        private readonly DbContextClass _dbContextClass;
        public GymMenu(DbContextClass dbContextClass)
        {
            _dbContextClass = dbContextClass;
        }

        public async Task<List<UserData>> GymGetDetails(int id)
        {
            var param = new SqlParameter("@id", id);
            var gymDetails = await Task.Run(() => _dbContextClass.UserData.FromSqlRaw("exec spUserLookup @id", param).ToListAsync());
            return gymDetails;
        }
    }
}
