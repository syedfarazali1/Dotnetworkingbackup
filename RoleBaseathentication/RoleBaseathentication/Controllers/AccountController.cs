using RoleBaseathentication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace RoleBaseathentication.Controllers
{
    [AllowAnonymous]
    public class AccountController : Controller
    {
        RoleBaseAuthorizeEntities db = new RoleBaseAuthorizeEntities();

        // GET: Account
        public ActionResult Login()
        {
            if(User.Identity.IsAuthenticated)
                    {
                return RedirectToAction("Index", "Employees");
            }
            return View();
        } 
        [HttpPost]
        public ActionResult Login(User model)
        {
            bool isvalid = db.Users.Any(x => x.UserName == model.UserName && x.Password == model.Password);
            if (isvalid)
            {
                FormsAuthentication.SetAuthCookie(model.UserName, false);
                return RedirectToAction("Index", "Employees");
            }
            ModelState.AddModelError("", "Invalid User Name and Password ");
            return View();
        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");

        }
        public ActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SignUp(User us)
        {
            db.Users.Add(us);
            db.SaveChanges();
            return RedirectToAction("Login");
        }
    }
}