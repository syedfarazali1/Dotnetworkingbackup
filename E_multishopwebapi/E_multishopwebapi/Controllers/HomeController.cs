using E_multishopwebapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace E_multishopwebapi.Controllers
{
    public class HomeController : Controller
    {
        E_commerce_ProjectEntities db = new E_commerce_ProjectEntities();
        public ActionResult Index()
        {
            ViewBag.list = db.allcategory();
             
            return View();
        }
        public ActionResult Indexs()
        {
            ViewBag.list = db.SPContact();
             
            return View();
        }
    }
}
