using BusinessLayer.Concrete;
using DataAccesLayer.Concrete;
using DataAccesLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace CoreMVC.ViewComponents.Writer
{
    
    public class WriterAboutOnDashboard:ViewComponent
    {

        WriterManager wm = new WriterManager(new EFWriterRepository());      
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            
            var username = User.Identity.Name;
            ViewBag.veri = username;
            var usermail = c.Users.Where(x=>x.UserName == username).Select(y=>y.Email).FirstOrDefault();
            var writerID = c.Writers.Where(x => x.WriterMail == usermail).Select(y => y.WriterId).FirstOrDefault();
            var values = wm.GetWriterById(writerID);
            return View(values);
        }
    }
}
