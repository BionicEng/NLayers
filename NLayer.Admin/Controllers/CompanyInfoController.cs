using Microsoft.AspNetCore.Mvc;

namespace NLayer.Admin.Controllers
{
    public class CompanyInfoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
