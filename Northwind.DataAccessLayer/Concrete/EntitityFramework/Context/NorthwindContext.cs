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
        public DbSet<User> Users { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().ToTable("Products");
            modelBuilder.Entity<User>().ToTable("Users");
            modelBuilder.Entity<OperationClaim>().ToTable("OperationClaims");
            modelBuilder.Entity<UserOperationClaim>().ToTable("UserOperationClaims");
            
        }
    }
    
}