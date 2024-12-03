using Gym_TrackerDKAPI.Entities;
using Microsoft.EntityFrameworkCore;


namespace Gym_TrackerDKAPI.Data
{
    public class DbContextClass : DbContext
    {
        protected readonly IConfiguration Configuration;
        public DbContextClass(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
        }

        public DbSet<Exercise> Exercise { get; set; }
        public DbSet<Apperal> Apperal { get; set; }
        public DbSet<ExtApperal> ExtApperal{get; set;}
    }
}
