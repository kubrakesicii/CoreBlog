using Microsoft.AspNetCore.Mvc;

namespace MVC.Controllers
{
    public class ErrorPageController : Controller
    {
        public IActionResult Error()
        {
            return View();
        }
    }
}
