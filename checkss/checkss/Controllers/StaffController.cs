using checkss.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace checkss.Controllers
{
    public class StaffController : Controller
    {
        Syed_companyEntities db = new Syed_companyEntities();
        public ActionResult Index()
        {
            var ss = db.staffs.ToList();
            return View(ss);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]

        public ActionResult Create(staff ss)
        {


            return View(ss);
        }
    }
}