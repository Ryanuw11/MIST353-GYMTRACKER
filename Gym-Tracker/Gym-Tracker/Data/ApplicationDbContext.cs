﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Gym_Tracker.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        internal readonly IEnumerable<object> Memberships;

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<GymTrackersAPI.Entities.UserData> UserData { get; set; } = default!;
    }
}



