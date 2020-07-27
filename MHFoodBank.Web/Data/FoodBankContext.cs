﻿using System;
using System.Collections.Generic;
using System.Text;
using MHFoodBank.Common;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MHFoodBank.Web.Data
{
    public class FoodBankContext : IdentityDbContext<AppUser, IdentityRole<int>, int>
    {
        public FoodBankContext(DbContextOptions<FoodBankContext> options)
            : base(options)
        {
        }

        public DbSet<VolunteerProfile> VolunteerProfiles { get; set; }
        public DbSet<Reference> References { get; set; }
        public DbSet<WorkExperience> WorkExperiences { get; set; }
        public DbSet<Shift> Shifts { get; set; }
        public DbSet<RecurringShift> RecurringShifts { get; set; }
        public DbSet<RecurringChildLink> ShiftLinks { get; set; }
        public DbSet<Availability> Availabilities { get; set; }
        public DbSet<Alert> Alerts { get; set; }
        public DbSet<ShiftRequestAlert> ShiftAlerts { get; set; }
        public DbSet<ApplicationAlert> ApplicationAlerts { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<PositionVolunteer> PositionVolunteers { get; set; }
        public DbSet<Reminder> Reminders { get; set; }
        public DbSet<ClockedTime> ClockedTime { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //https://stackoverflow.com/questions/37969146/asp-identity-role-does-not-exist-error/39259481

            modelBuilder.Entity<AppUser>().Ignore(p => p.AccessFailedCount);
            modelBuilder.Entity<AppUser>().Ignore(p => p.LockoutEnabled);
            modelBuilder.Entity<AppUser>().Ignore(p => p.LockoutEnd);
            modelBuilder.Entity<AppUser>().Ignore(p => p.PhoneNumber);
            modelBuilder.Entity<AppUser>().Ignore(p => p.PhoneNumberConfirmed);

            modelBuilder.Entity<Reference>().HasOne(p => p.Volunteer).WithMany(b => b.References).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<WorkExperience>().HasOne(p => p.Volunteer).WithMany(b => b.WorkExperiences).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Availability>().HasOne(p => p.Volunteer).WithMany(b => b.Availabilities).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Shift>().HasOne(p => p.Volunteer).WithMany(b => b.Shifts).OnDelete(DeleteBehavior.SetNull);
            modelBuilder.Entity<Alert>().HasOne(p => p.Volunteer).WithMany(b => b.Alerts).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Shift>().HasOne(p => p.ParentRecurringShift).WithMany(b => b.ExcludedShifts).OnDelete(DeleteBehavior.SetNull);
            modelBuilder.Entity<PositionVolunteer>().HasOne(p => p.Volunteer).WithMany(b => b.Positions).OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<AppUser>()
                .HasOne(l => l.VolunteerProfile)
                .WithOne(s => s.User)
                .HasForeignKey<VolunteerProfile>(l => l.UserID)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<IdentityRole<int>>().HasData(new List<IdentityRole<int>>
            {
                new IdentityRole<int>
                {
                    Id = 1,
                    Name = "Admin",
                    NormalizedName = "ADMIN"
                },
                new IdentityRole<int>
                {
                    Id = 2,
                    Name = "Staff",
                    NormalizedName = "STAFF"
                },
                new IdentityRole<int>
                {
                    Id = 3,
                    Name = "Volunteer",
                    NormalizedName = "VOLUNTEER"
                }
            });

            modelBuilder.Entity<Position>().HasData(new List<Position>
            {
                new Position
                {
                    Id = 1,
                    Name = "All"
                },
                new Position
                {
                    Id = 2,
                    Name = "General Maintenance"
                },
                new Position
                {
                    Id = 3,
                    Name = "Janitorial"
                },
                new Position
                {
                    Id = 4,
                    Name = "Front Stock"
                },
                new Position
                {
                    Id = 5,
                    Name = "Warehouse"
                },
                new Position
                {
                    Id = 6,
                    Name = "Community Relations"
                },
                new Position
                {
                    Id = 7,
                    Name = "Special Events"
                }
            });
        }
    }
}
