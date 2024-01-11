using Microsoft.AspNetCore.Mvc;

namespace NLayer.Admin.Controllers
{
    public class SchoolDepartmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
