using EmployeeManagerRazor.Models;
using EmployeeManagerRazor.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EmployeeManagerRazor.Pages.Employees
{

	[BindProperties]
    public class EditModel : PageModel
    {
		private readonly ApplicationDbContext _db;

		public Employee Employee { get; set; }


		public EditModel(ApplicationDbContext db)
		{
			_db = db;
		}
		public void OnGet(int? id)
        {
			if (id != null && id!=0)
			{
				Employee = _db.Employees.Find(id);
			}

        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
				_db.Employees.Update(Employee);
				_db.SaveChanges();
				return RedirectToPage("Index");
			}
			return Page();
           
		}
    }
}
