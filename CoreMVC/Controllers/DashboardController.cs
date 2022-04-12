using DataAccesLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CoreMVC.Controllers
{
    [AllowAnonymous]
    public class DashboardController : Controller
    {

        public IActionResult Index()
        {
            Context c = new Context();

            var username = User.Identity.Name;
            var usermail = c.Users.Where(x => x.UserName == username).Select(y => y.Email).FirstOrDefault();
            var writerid = c.Writers.Where(x=>x.WriterMail == usermail).Select(x => x.WriterId).FirstOrDefault();

            ViewBag.v1 = c.Blogs.Count().ToString();
            ViewBag.v2 = c.Blogs.Where(x => x.WriterId == writerid).Count();
            ViewBag.v3 = c.Categories.Count();
            return View();
        }
    }
}
