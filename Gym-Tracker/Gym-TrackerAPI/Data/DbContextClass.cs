﻿using Gym_TrackerAPI.Entities;
using Microsoft.EntityFrameworkCore;


namespace Gym_TrackerAPI.Data
{


    public class ApplicationDbContext : DbContext
    {
        //the following code inputs the db data for everyones individual enitiy classes
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
                : base(options) { }
        public DbSet<UserData> UserData { get; set; }

        public DbSet<GymLoc> GymLoc { get; set; }
        public DbSet<Apperal> Apperal { get; set; }
        public DbSet<Course> Course { get; set; }
        public DbSet<Exercise> Exercise { get; set; }
        public DbSet<Membership> Membership { get; set; }

 
    }
}
