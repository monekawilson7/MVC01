using Microsoft.AspNetCore.Mvc;

namespace DemoMVC.Controllers
{
    public class AccountsController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
