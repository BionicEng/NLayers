using Microsoft.AspNetCore.Mvc;

namespace NLayer.Admin.Controllers
{
    public class KnownProgramController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
