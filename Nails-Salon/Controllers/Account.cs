using Microsoft.AspNetCore.Mvc;

namespace Nails_Salon.Controllers
{
    public class Account : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
    }
}