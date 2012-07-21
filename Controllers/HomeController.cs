using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mvc.Mailer;
using TestMvc.Mailers;

namespace TestMvc.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to AppHarbor!";
            //IUserMailer mailer = new UserMailer();
            //mailer.Welcome().Send();
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Email()
        {
            var email = new Email();
            return View(email);
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Email(Email email)
        {
            var db = new dbEntities();
            db.AddToForwardedEmails(new ForwardedEmail()
                                        {
                                            Created = DateTime.Now,
                                            From = email.From,
                                            Plain = email.Plain,
                                            Subject = email.Subject
                                        });
            db.SaveChanges();
            return new EmptyResult();
        }
    }

    public class Email
    {
        public string From { get; set; }
        public string Plain { get; set; }
        public string Subject { get; set; }
    }
}
