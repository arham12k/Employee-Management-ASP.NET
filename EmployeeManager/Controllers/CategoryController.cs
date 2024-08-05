using Microsoft.AspNetCore.Mvc;

namespace EmployeeManager.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
