using crud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace crud.Controllers
{
    public class HomeController : Controller
    {
        TestEntities db = new TestEntities();
        public ActionResult Index()
        {
            List<Registration> li = db.Registrations.ToList();
            return View(li);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();


        }

        [HttpPost]
        public ActionResult Create(Registration reg,HttpPostedFileBase pic)
        {
          
            reg.Email = pic.FileName;
            
            db.Registrations.Add(reg);
            db.SaveChanges();
         return RedirectToAction("Index");


        }
    }
}