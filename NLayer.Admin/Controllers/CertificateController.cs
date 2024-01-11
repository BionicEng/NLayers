using Microsoft.AspNetCore.Mvc;

namespace NLayer.Admin.Controllers
{
    public class CertificateController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
