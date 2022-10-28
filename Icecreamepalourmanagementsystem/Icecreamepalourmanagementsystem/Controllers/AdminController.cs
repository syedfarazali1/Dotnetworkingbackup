using Icecreamepalourmanagementsystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Icecreamepalourmanagementsystem.Controllers
{
    public class AdminController : Controller
    {
        dbicecreamepalourEntities db = new dbicecreamepalourEntities();


        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Dashboard()
        {
            return View();
        }
        [HttpGet]
        public ActionResult login()
        {
            if (Session["Ad"] != null)
            {
                return RedirectToAction("Dashboard");

            }
            else if (Session["Us"] != null)
            {
                return RedirectToAction("Index", "User");

            }
            return View();
        }
        
        [HttpPost]
        public ActionResult Login(tbluser u)
        {
            if (u!= null)
            {
                var result = db.tblusers.Where( x => x.UserName == u.UserName && x.Password == u.Password).FirstOrDefault();
                if (result != null)
                {
                    if (result.usertype ==2 )
                    {
                        Session["Ad"] = result.User_ID;
                        return RedirectToAction("Dashboard");
                    }

                    else
                    {
                        Session["Us"] = result.User_ID;
                        return RedirectToAction("Index", "User");
                    }
                }
                else
                {
                    return View("login");
                }
            }
            return View();
        }
        [HttpGet]
        public ActionResult logout()
        {

            if (Session["Ad"] != null)
            {
                Session.Clear();
                return RedirectToAction("Index", "User");

            }
            else if (Session["Us"] != null)
            {
                Session.Clear();
                return RedirectToAction("Index", "User");

            }
            return View();
        }
    }
}