using Gym_TrackerAPI.Data;
using Gym_TrackerAPI.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;



namespace Gym_TrackerAPI.Repositiories
{

    public class LocationMenu : ILocationMenu
    {
        private readonly DbContextClass _dbContextClass;
        public LocationMenu(DbContextClass dbContextClass)
        {
            _dbContextClass = dbContextClass;
        }

        public async Task<List<GymLoc>> LocationGetDetails(string gym_name)
        {
            var param = new SqlParameter("@gym_name", gym_name);
            var gymLocations = await _dbContextClass.GymLoc.FromSqlRaw("exec spGymLocAndOpen @gym_name", param).ToListAsync();


            return gymLocations;
        }
    }
}