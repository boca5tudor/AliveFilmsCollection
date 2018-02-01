using AliveFilmCollection.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AliveFilmCollection.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

      //  [Authorize] this forces user to log in first
        public ActionResult Index()
        {
            var userId = User.Identity.GetUserId();
            var userDetailId = db.UserDetails.Where(c => c.ApplicationUserId ==
              userId).First().ID;

            ViewBag.UserDetailsId = userDetailId;

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.TheMessage = "Send a feedback message!";

            return View();
        }

        [HttpPost]
        public ActionResult Contact(string message)
        {
            // TODO: send message to HQ
            if (!message.Equals(""))
            {
                ViewBag.TheMessage = "Thank you for the feedback message!";
            }


            return PartialView("contactThanks");
        }


    }
}