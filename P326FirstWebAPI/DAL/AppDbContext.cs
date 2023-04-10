using Microsoft.EntityFrameworkCore;
using P326FirstWebAPI.Data.Configuritions;
using P326FirstWebAPI.Models;

namespace P326FirstWebAPI.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductConfigurition());
            base.OnModelCreating(modelBuilder);
        }
    }
}
