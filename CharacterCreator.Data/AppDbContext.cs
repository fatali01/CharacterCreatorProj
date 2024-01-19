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
            base.OnModelCreating(modelBuilder);
            {
                modelBuilder.Entity<CharacterEntity>().HasData(
                    new CharacterEntity()
                    {
                    CharacterId = 1,
                    WarriorType = "Paladin",
                    CharacterName = "Rigo",
                    CharacterAge = 73,
                    CharacterDescription = "Very fast man", 
                    BirthLocation = "Elysium",
                    TeamId = 1
                    },
                    new CharacterEntity()
                    {
                    CharacterId = 2,
                    WarriorType = "Barbarian",
                    CharacterName = "Ali",
                    CharacterAge = 12,
                    CharacterDescription = "Very stronk man", 
                    BirthLocation = "Xandu",
                    TeamId = 1
                    },
                    new CharacterEntity()
                    {
                    CharacterId = 3,
                    WarriorType = "Sorcerer",
                    CharacterName = "Ryan",
                    CharacterAge = 7341,
                    CharacterDescription = "Very wise man", 
                    BirthLocation = "Valhallf",
                    TeamId = 2
                    },
                    new CharacterEntity()
                    {
                    CharacterId = 4,
                    WarriorType = "Assassin",
                    CharacterName = "Terry",
                    CharacterAge = 35,
                    CharacterDescription = "Very scary man", 
                    BirthLocation = "Indianapolis",
                    TeamId = 2
                    },
                    new CharacterEntity()
                    {
                    CharacterId = 5,
                    WarriorType = "Druid",
                    CharacterName = "Jimbob",
                    CharacterAge = 55,
                    CharacterDescription = "Very dumb but coo man", 
                    BirthLocation = "The Holler",
                    TeamId = 3
                    },
                    new CharacterEntity
                    {
                    CharacterId = 6,
                    WarriorType = "Regular Dude",
                    CharacterName = "Regular Joe",
                    CharacterAge = 30,
                    CharacterDescription = "Just a regular dude", 
                    BirthLocation = "A regular place",
                    TeamId = 3
                    }
                );


            modelBuilder.Entity<FeatureEntity>().HasData(
                new FeatureEntity()
                {
                    FeatureId = 1,
                    EyeColor = "Purple",
                    HairStyle = "Perm",
                    HairColor = "Green",
                    Height = "7ft 3in",
                    Weight = "150lb",
                    BodyType = "Slender",
                    Ability = "Dexterity",
                    SkinColor = "Fair",
                    CharacterId = 1
                },
                new FeatureEntity()
                {
                    FeatureId = 1,
                    EyeColor = "Red",
                    HairStyle = "Spiked",
                    HairColor = "Red",
                    Height = "6ft 1in",
                    Weight = "180lb",
                    BodyType = "Slim",
                    Ability = "Strength",
                    SkinColor = "Light",
                    CharacterId = 2
                },
                new FeatureEntity()
                {
                    FeatureId = 1,
                    EyeColor = "Pink",
                    HairStyle = "Bald",
                    HairColor = "Not applicable",
                    Height = "5'10",
                    Weight = "600lb",
                    BodyType = "Rotund",
                    Ability = "Wisdom",
                    SkinColor = "Fair-Dark",
                    CharacterId = 3
                },
                new FeatureEntity()
                {
                    FeatureId = 1,
                    EyeColor = "Brown",
                    HairStyle = "Short",
                    HairColor = "Brown",
                    Height = "6feet 3in",
                    Weight = "200",
                    BodyType = "Athletic",
                    Ability = "Stealth",
                    SkinColor = "Fair-Light",
                    CharacterId = 4
                },
                new FeatureEntity()
                {
                    FeatureId = 1,
                    EyeColor = "Blue",
                    HairStyle = "Long Hair",
                    HairColor = "Blue",
                    Height = "4feet 12in",
                    Weight = "100lb",
                    BodyType = "Petite",
                    Ability = "Healing",
                    SkinColor = "Very Dark",
                    CharacterId = 5
                },
                new FeatureEntity()
                {
                    FeatureId = 1,
                    EyeColor = "Yellow",
                    HairStyle = "Mullet",
                    HairColor = "Yellow",
                    Height = "5feet 5in",
                    Weight = "400lb",
                    BodyType = "Rotund",
                    Ability = "Regularness",
                    SkinColor = "Very Light",
                    CharacterId = 6
                }
            );

            modelBuilder.Entity<TeamEntity>().HasData(
                new TeamEntity()
                {
                    TeamId = 1,
                    TeamName = "Kool Kids",
                    TeamNumber = 17,
                    TeamSlogan = "To Infinity And Beyond!",
                    TeamDescription = "They really aren't very cool",
                    TeamMission = "Chyllin"
                },
                new TeamEntity()
                {
                    TeamId = 2,
                    TeamName = "The Losers",
                    TeamNumber = 0,
                    TeamSlogan = "FBGM",
                    TeamDescription = "This team is not very effective",
                    TeamMission = "Not Failing"
                },
                new TeamEntity()
                {
                    TeamId = 3,
                    TeamName = "Chads",
                    TeamNumber = 69,
                    TeamSlogan = "Send It!",
                    TeamDescription = "Everyone aspires to be them",
                    TeamMission = "World Domination"
                }
            );
        }
        }
    }
}
