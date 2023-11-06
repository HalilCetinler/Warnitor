using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Warnitor.UI.Models;

namespace Warnitor.UI.Controllers
{
    public class AuthController : Controller
    {
        private readonly ILogger<AuthController> _logger;

        public AuthController(ILogger<AuthController> logger)
        {
            _logger = logger;
        }
		public IActionResult AuthForgot()
		{
			return View();
		}
		public IActionResult Login()
        {
            return View();
        }
		public IActionResult AuthRegister()
		{
			return View();
		}
		
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}