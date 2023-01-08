using Microsoft.AspNetCore.Mvc;

namespace DigiKala.Controllers
{
    public class AccountsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
