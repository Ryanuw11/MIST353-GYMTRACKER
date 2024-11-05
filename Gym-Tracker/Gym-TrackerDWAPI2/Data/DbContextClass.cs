using Gym_TrackerDWAPI.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Gym_TrackerDWAPI.Data
{
    public class DbContextClass : DbContext
    {
        public DbContextClass(DbContextOptions<DbContextClass> options) : base(options) { }

        
        public DbSet<WeatherData> WeatherData { get; set; } 
    }
}
