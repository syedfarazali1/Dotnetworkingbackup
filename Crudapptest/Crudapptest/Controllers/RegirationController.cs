using Crudapptest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Crudapptest.Controllers
{
    public class RegirationController : Controller
    {
        WebContext db = new WebContext();
        public ActionResult Index()
        {
            var data = db.Registrations.ToList();
            return View(data);
        }   
        
        public ActionResult Create()
        {
            return View();
        }

        //public ActionResult Create()
        //{
        //    return View();
        //}
    }
}