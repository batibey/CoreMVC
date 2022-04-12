using Microsoft.AspNetCore.Mvc;

namespace CoreMVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class WidegetController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
