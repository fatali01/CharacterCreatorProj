using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CharacterCreator.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace CharacterCreator.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) {}

        public DbSet<CharacterEntity> Characters {get; set;}

        public DbSet<FeatureEntity> Features {get; set;}
        public DbSet<TeamEntity> Teams {get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);ModelBuilder modelBuilder)
            {
                modelBuilder.Entity<Conference>().HasData(
                    protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Restaurant>().HasData(
                new Restaurant()
                {
                    ID = 1,
                    Name = "Super Mario Pasta Cavern",
                    Address = "1Up Lane"
                }
            );

            modelBuilder.Entity<Rating>().HasData(
                new Rating()
                {
                    ID = 1,
                    RestaurantID = 1,
                    FoodScore = 7.5,
                    EnvironmentScore = 8.8d,
                    CleanlinessScore = 10
                },
                 new Rating()
                {
                    ID = 2,
                    RestaurantID = 1,
                    FoodScore = 8.5,
                    EnvironmentScore = 9.8d,
                    CleanlinessScore = 9.9
                }
            );
        }


Terry Brown - Instructor
  4:09 AM
RestaurantRaterAPI Pt.2 :
4:09
https://zoom.us/rec/share/c2M0Gzv3G6rldfsHPZtcV6qtK-llKeCi9eWV2VUXBrU2G5KtsgiNjPHzpDH37Wlw.DFlH-57OsgJJGezi?startTime=1703111589000
Passcode: Rr#5#Qm@


Terry Brown - Instructor
  6:26 PM
  protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Conference>().HasData(
                new Conference
                {
                    Id = 1,
                    Name = "American Football Conference"
                },
                new Conference
                {
                    Id = 2,
                    Name = "National Football Conference"
                }
            );

            modelBuilder.Entity<Division>().HasData(
                new Division()
                {
                    Id = 1,
                    Name = "AFC EAST",
                    ConferenceId = 1
                },
                new Division()
                {
                    Id = 2,
                    Name = "AFC North",
                    ConferenceId = 1
                },
                new Division()
                {
                    Id = 3,
                    Name = "AFC SOUTH",
                    ConferenceId = 1
                },
                new Division()
                {
                    Id = 4,
                    Name = "AFC WEST",
                    ConferenceId = 1
                },
                 new Division()
                 {
                     Id = 5,
                     Name = "NFC EAST",
                     ConferenceId = 2
                 },
                 new Division()
                 {
                     Id = 6,
                     Name = "NFC NORTH",
                     ConferenceId = 2
                 },
                new Division()
                {
                    Id = 7,
                    Name = "NFC SOUTH",
                    ConferenceId = 2
                },
                new Division()
                {
                    Id = 8,
                    Name = "NFC WEST",
                    ConferenceId = 2
                }
            );

            modelBuilder.Entity<Team>().HasData(
                new Team()
                {
                    Id =1,
                    Name = "Miami Dolphins",
                    Wins = 11,
                    Losses = 5,
                    Ties = 0,
                    HomeRecord = "7-1-0",
                    RoadRecord = "4-4-0",
                    DivisionId = 1
                },
                new Team()
                {
                    Id =2,
                    Name = "Buffalo Bills",
                    Wins = 10,
                    Losses = 6,
                    Ties = 0,
                    HomeRecord = "7-2-0",
                    RoadRecord = "3-4-0",
                    DivisionId = 1
                },
                new Team()
                {
                    Id =3,
                    Name = "New York Jets",
                    Wins = 6,
                    Losses = 10,
                    Ties = 0,
                    HomeRecord = "4-5-0",
                    RoadRecord = "2-5-0",
                    DivisionId = 1
                },
                new Team()
                {
                    Id =4,
                    Name = "New England Patriots",
                    Wins = 4,
                    Losses = 12,
                    Ties = 0,
                    HomeRecord = "1-7-0",
                    RoadRecord = "3-5-0",
                    DivisionId = 1
                },
                new Team()
                {
                    Id =5,
                    Name = "Baltimore Ravens",
                    Wins = 13,
                    Losses = 3,
                    Ties = 0,
                    HomeRecord = "6-2-0",
                    RoadRecord = "7-1-0",
                    DivisionId = 2
                },
                new Team()
                {
                    Id =6,
                    Name = "Cleveland Browns",
                    Wins = 11,
                    Losses = 5,
                    Ties = 0,
                    HomeRecord = "8-1-0",
                    RoadRecord = "3-4-0",
                    DivisionId = 2
                },
                new Team()
                {
                    Id =7,
                    Name = "Pittsburgh Steelers",
                    Wins = 9,
                    Losses = 7,
                    Ties = 0,
                    HomeRecord = "5-4-0",
                    RoadRecord = "4-3-0",
                    DivisionId = 2
                },
                new Team()
                {
                    Id =8,
                    Name = "Cincinnati Bengals",
                    Wins = 8,
                    Losses = 8,
                    Ties = 0,
                    HomeRecord = "5-3-0",
                    RoadRecord = "3-5-0",
                    DivisionId = 2
                }
            );
        }
                )
            }
        }()
    }
}