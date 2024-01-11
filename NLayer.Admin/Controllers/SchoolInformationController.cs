using Microsoft.AspNetCore.Mvc;

namespace NLayer.Admin.Controllers
{
    public class SchoolInformationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
