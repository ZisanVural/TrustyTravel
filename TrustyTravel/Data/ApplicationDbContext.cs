using Microsoft.EntityFrameworkCore;
using TrustyTravel.Models;

namespace TrustyTravel.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> dbContextOptions) : base(dbContextOptions)
        {

        }
        public DbSet<Hotels> Hotels { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Questions> Questions { get; set; }
        public DbSet<Trip> Trips { get; set; }
        public DbSet<Restaurants> Restaurants { get; set; }
        public DbSet<Flights> Flights { get; set; }
        public DbSet<Comments> Comments { get; set; }
        public DbSet<Others> other { get; set; }
    }
}

