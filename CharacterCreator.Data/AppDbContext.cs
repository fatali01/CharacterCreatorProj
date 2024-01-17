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
        }
    }
}