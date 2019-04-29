using InitTrackerApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace InitTrackerApp.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext (DbContextOptions<DataContext> options) : base (options) { }     
        
        public DbSet<Creature> Creatures { get; set; }
    }
}