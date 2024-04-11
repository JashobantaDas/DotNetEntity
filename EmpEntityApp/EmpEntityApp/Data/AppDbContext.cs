using Microsoft.EntityFrameworkCore;

namespace EmpEntityApp.Data
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {
        
        }
    }
}
