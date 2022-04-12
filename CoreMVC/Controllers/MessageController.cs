using BusinessLayer.Concrete;
using DataAccesLayer.Concrete;
using DataAccesLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace CoreMVC.Controllers
{
    
    public class MessageController : Controller
    {
        Context c = new Context();
        Message2Manager nm = new Message2Manager(new EFMessage2Repository());
        public IActionResult Inbox()
        {
            
            var username = User.Identity.Name;
            var usermail = c.Users.Where(x => x.UserName == username).Select(y => y.Email).FirstOrDefault();
            var writerID = c.Writers.Where(x => x.WriterMail == usermail).Select(y => y.WriterId).FirstOrDefault();
            var values = nm.GetInboxListByWriter(writerID);
            return View(values);
        }

        public IActionResult Sendbox()
        {
            var username = User.Identity.Name;
            var usermail = c.Users.Where(x => x.UserName == username).Select(y => y.Email).FirstOrDefault();
            var writerID = c.Writers.Where(x => x.WriterMail == usermail).Select(y => y.WriterId).FirstOrDefault();
            var values = nm.GetSendboxListByWriter(writerID);
            return View(values);
        }
        
        public IActionResult MessageDetails(int id)
        {
            var value = nm.TGetByID(id);
            
            return View(value);
        }

        [HttpGet]
        public IActionResult SendMessage()
        {
            return View();  
        }
        [HttpPost]
        public IActionResult SendMessage(Message2 p)
        {
            var username = User.Identity.Name;
            var usermail = c.Users.Where(x => x.UserName == username).Select(y => y.Email).FirstOrDefault();
            var writerID = c.Writers.Where(x => x.WriterMail == usermail).Select(y => y.WriterId).FirstOrDefault();
            p.SenderID = writerID;
            p.ReceiverID = 2;
            p.MessageStatus = true;
            p.MessageDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            nm.TAdd(p);
            return RedirectToAction("Inbox");
        }
    }
}
