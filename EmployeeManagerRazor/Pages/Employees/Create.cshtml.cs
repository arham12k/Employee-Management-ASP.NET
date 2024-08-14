using EmployeeManagerRazor.Data;
using EmployeeManagerRazor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EmployeeManagerRazor.Pages.Employees
{
    public class CreateModel : PageModel
    {
		private readonly ApplicationDbContext _db;

		[BindProperty]
		public Employee Employee { get; set; }


		public CreateModel(ApplicationDbContext db)
		{
			_db = db;
		}
		public void OnGet()
        {
        }

		public IActionResult OnPost()
		{
			_db.Employees.Add(Employee);
			_db.SaveChanges();
			return RedirectToPage("Index");

		}
    }
}
