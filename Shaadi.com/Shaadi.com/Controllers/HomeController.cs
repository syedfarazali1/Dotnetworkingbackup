using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Shaadi.com.Models;

namespace Shaadi.com.Controllers
{
    public class HomeController : Controller
    {
        Entities db = new Entities();

        public ActionResult Index()
        {
            

            return View(db.Tbl_Profile.ToList());
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Tbl_Profile data)
        {
            return View();
        }
    }
}