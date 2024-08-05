using EmployeeManager.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManager.Data
{
    public class ApplicationDbContext:DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
                
        }

        public DbSet<Category> Categories { get; set; }
    }
}
