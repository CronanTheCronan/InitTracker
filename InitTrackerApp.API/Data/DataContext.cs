using InitTrackerApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace InitTrackerApp.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext (DbContextOptions<DataContext> options) : base (options) { }     
        
        public DbSet<Creature> Creatures { get; set; }
        public DbSet<Condition> Conditions { get; set; }
        public DbSet<Content> Content { get; set; }
        public DbSet<Hero> Heroes { get; set; }
        public DbSet<HeroExtended> HeroesExtended { get; set; }
        public DbSet<HeroGroupXref> HeroesGroupXref { get; set; }
        public DbSet<HeroGroups> HeroesGroups { get; set; }
        public DbSet<Monster> Monsters { get; set; }
        public DbSet<MonsterGroup> MonsterGroups { get; set; }
        public DbSet<MonsterExtended> MonstersExtended { get; set; }
        public DbSet<MonsterGroupXref> MonstersGroupXref { get; set; }
        public DbSet<User> Users { get; set; }
    }
}