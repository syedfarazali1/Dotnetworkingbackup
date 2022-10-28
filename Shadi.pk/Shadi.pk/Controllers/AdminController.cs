using Shadi.pk.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Shadi.pk.Controllers
{

    public class AdminController : Controller
    {
        private WebContext db = new WebContext();

        public ActionResult Pro_Index()
        {

            return View(db.Tbl_Profile.ToList());
        }
        public ActionResult Re_Index()
        {

            return View(db.tbl_Registration.ToList());
        }
        public ActionResult Re_Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Re_Create(tbl_Registration tbl_Registration)
        {
       
            if (ModelState.IsValid)
            {
                db.tbl_Registration.Add(tbl_Registration);
                db.SaveChanges();
                return RedirectToAction("Pro_Create");
            }

            return View(tbl_Registration);
        }

        public ActionResult Pro_Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Pro_Create(Tbl_Profile tbl_Profile)
        {
            if (ModelState.IsValid)
            {
                db.Tbl_Profile.Add(tbl_Profile);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tbl_Profile);
        }
    }
}