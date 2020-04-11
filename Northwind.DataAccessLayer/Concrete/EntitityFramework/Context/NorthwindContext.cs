using Microsoft.EntityFrameworkCore;
using Northwind.EntitiesLayer.Concrete;

namespace Northwind.DataAccessLayer.Concrete.EntitityFramework.Context
{
  
        public class NorthwindContext : DbContext
    {
     
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost,1433\\Catalog=Northwind;Database=Northwind;User=sa;Password=DockerSql123;");
        }
     

        public DbSet<Product> Products { get; set; }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().ToTable("Products");
            
        }
    }
    
}