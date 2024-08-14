using EmployeeManagerRazor.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagerRazor.Data
{
	public class ApplicationDbContext : DbContext
	{

		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
		{

		}

		public DbSet<Employee> Employees { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee { Id = 1, Name = "Arham khan", Mobile = 6267316504, Email="khanarham8962@gmail.com"},
				new Employee { Id = 2, Name = "Rimsha arham", Mobile = 8109746520, Email = "arim6@gmail.com" }

			);
        }
	}
}
