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
            IUserMailer mailer = new UserMailer();
            mailer.Welcome().Send();
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
