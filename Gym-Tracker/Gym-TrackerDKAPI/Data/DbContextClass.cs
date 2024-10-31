using Gym_TrackerDKAPI.Entities;
using Microsoft.EntityFrameworkCore;


namespace Gym_TrackerDKAPI.Data
{
    public class DbContextClass : DbContext
    {
        public DbContextClass(DbContextOptions<DbContextClass> options) : base(options)
        { }
        public DbSet<Exercise> Exercise { get; set; }
        public DbSet<Apperal> Apperal { get; set; }

    }
}
