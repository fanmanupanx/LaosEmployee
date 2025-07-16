
using Microsoft.EntityFrameworkCore;
using LaosEmployee.Models;

namespace LaosEmployee.DBContext
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options)
            : base(options)
        {
        }

        public DbSet<Temploy1> Temploy1 { get; set; }
    }
}