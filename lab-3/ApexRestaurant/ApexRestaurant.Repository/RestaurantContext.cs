using Microsoft.EntityFrameworkCore;
using ApexRestaurant.Repository.Domain;

namespace ApexRestaurant.Repository
{
    public class RestaurantContext : DbContext
    {

        public DbSet<Customer> Customers { get; set; }

        public RestaurantContext(DbContextOptions<RestaurantContext> options) : base(options)
        {
        }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Your model configuration here
        }
        // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        // {
        //     base.OnConfiguring(optionsBuilder);
        //     // Ensure that the SQLite database is created if it doesn't exist
        //     optionsBuilder.UseSqlite("Data Source=ApexRestaurant.main.db");
        // }
    }
}