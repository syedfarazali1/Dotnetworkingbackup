using Crudapptest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Crudapptest.Controllers
{
    public class HomeController : Controller
    {
        WebContext db = new WebContext(); 
        public ActionResult Index()
        {
            List<Registration> registrations = db.Registrations.ToList();
            return View(registrations);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}