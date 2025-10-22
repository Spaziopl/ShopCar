using CarSeller.Models;
using Microsoft.EntityFrameworkCore;
namespace CarSeller.Data
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) 
            : base(options) 
        {
        }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Owner> Owners { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>()
                .Property(c => c.Price)
                .HasColumnType("decimal(18,2)");
        }
    }
}
