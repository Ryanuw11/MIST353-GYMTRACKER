using Gym_TrackerJMAPI.Entities;
using Microsoft.EntityFrameworkCore;

// Adding DB context to membership

namespace Gym_TrackerJMAPI.Data
{
    public class DbContextClass : DbContext
    {
        public DbContextClass(DbContextOptions<DbContextClass> options) : base(options)
        { }
        public DbSet<Membership> Membership { get; set; }

    }
}
