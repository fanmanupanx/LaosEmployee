
using Microsoft.EntityFrameworkCore;
using LaosEmployee.Models;

namespace LaosEmployee.DBContext
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<UserLogin> UserLogins { get; set; }
    }
}
