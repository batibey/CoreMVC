using DataAccesLayer.EntityFramework;
using BusinessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using DataAccesLayer.Concrete;
using System.Linq;

namespace CoreMVC.ViewComponents.Writer
{
    public class WriterMessageNotification:ViewComponent
    {
        Message2Manager mm = new Message2Manager(new EFMessage2Repository());
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            var username = User.Identity.Name;
            var usermail = c.Users.Where(x => x.UserName == username).Select(y => y.Email).FirstOrDefault();
            var writerID = c.Writers.Where(x => x.WriterMail == usermail).Select(y => y.WriterId).FirstOrDefault();

            var values = mm.GetInboxListByWriter(writerID);
            return View(values);
        }
    }
}
