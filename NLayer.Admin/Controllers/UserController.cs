using Microsoft.AspNetCore.Mvc;
using NLayers.Business.Models;
using NLayers.Business.Services.Concrete;

namespace NLayer.Admin.Controllers
{
    public class UserController : Controller
    {
        private readonly UserService _userService;

        public UserController(UserService userService)
        {
            _userService = userService;
        }
        [HttpGet]
        public async Task<IActionResult>  Index()
        {
            var users = await _userService.GetAllUsers();
        
            return View(users);
        }

        [HttpGet]
        public IActionResult Details()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create([FromForm]UserViewModel userViewModel)
        {
            return View();
        }
        [HttpGet]
        public IActionResult Update()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Update([FromForm] UserViewModel userViewModel, int id)
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            _userService.DeleteUser(id);
            return RedirectToAction(nameof(Index));
        }

    }
}
