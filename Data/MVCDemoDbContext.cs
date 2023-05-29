using Microsoft.EntityFrameworkCore;
using SimpleCrud.Models.Domain;

namespace SimpleCrud.Data
{
    public class MVCDemoDbContext : DbContext
    {
        public MVCDemoDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
