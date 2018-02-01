using AliveFilmCollection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AliveFilmCollection.Controllers
{
    public class UserDetailsController : Controller
    {
        // GET: UserDetails
        public ActionResult Index()
        {
            return View();
        }

        // GET: UserDetails/Details
        public ActionResult Details()
        {
            //model-view interaction testing
            var userDetails = new UserDetails
            {
                FirstName = "Tudor",
                LastName = "Boca",
                FavouriteFilm = "Boy",
                Email = "boca@yahoo.com"
            };
            return View(userDetails);
        }

        // GET: UserDetails/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UserDetails/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: UserDetails/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UserDetails/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: UserDetails/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UserDetails/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
