using Microsoft.AspNetCore.Mvc;

namespace MinhaPrimeiraAPI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
