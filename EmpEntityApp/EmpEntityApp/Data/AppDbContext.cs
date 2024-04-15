using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace EmpEntityApp.Data
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {
        
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure entity mappings here using fluent API or data annotations
            modelBuilder.Entity<Role>().HasData(
                new Role() { RoleId = 1, UserRole = "Admin" },
                new Role() { RoleId = 2, UserRole = "Employee"},
                new Role() { RoleId = 3, UserRole = "Hr"}
            );

        }

        public DbSet<User> User { get; set; }
        public DbSet<Role> Role { get; set; }   

    }
}
