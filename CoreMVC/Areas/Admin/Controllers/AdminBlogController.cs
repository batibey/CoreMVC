using BusinessLayer.Concrete;
using DataAccesLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreMVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminBlogController : Controller
    {

        BlogManager blogmanager = new BlogManager(new EFBlogRepository());
        
        public IActionResult Index()
        {
            var values = blogmanager.GetBlogListWithCategory();
            return View(values);
        }
    }
}
