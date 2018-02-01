using AliveFilmCollection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AliveFilmCollection.Controllers
{
    public class UserFilmsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: UserFilms/AddFilms
        public ActionResult AddFilms()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddFilms(UserFilms userFilms)
        {
            if (ModelState.IsValid)
            {
                db.UserFilms.Add(userFilms);
                db.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            return View();
        }

        public ActionResult MyFilmList(int id)
        {
            var checkAccuount = db.UserFilms.Find(id);
            return View(checkAccuount.Title.ToList());
        }
    }
}