using Microsoft.EntityFrameworkCore;
using SPEntity.Model;

namespace SPEntity.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options): base(options) { }
        public DbSet<Employee> Employees { get; set; }
    }
}
