using Gym_TrackerJMAPI.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;


namespace Gym_TrackerJMAPI.Data
{
    public class DbContextClass : DbContext
    {
        public DbContextClass(DbContextOptions<DbContextClass> options) : base(options)
        { }
        public DbSet<Exercise> Exercise { get; set; }
        public DbSet<Apperal> Apperal { get; set; }

    }
}
