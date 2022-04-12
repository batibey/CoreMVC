using BusinessLayer.Concrete;
using DataAccesLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreMVC.ViewComponents.Writer
{
    public class WriterNotification:ViewComponent
    {
        NotificationManager NM = new NotificationManager(new EFNotificationRepository());

        public IViewComponentResult Invoke()
        {
            var values = NM.GetList();
            return View(values);
        }
    }
}
