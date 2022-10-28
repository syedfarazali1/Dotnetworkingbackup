using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;
using Test.Models;

namespace Test.Controllers
{
    public class RegistrationController : Controller
    {
        WebContaxt db = new WebContaxt();
        public ActionResult Index()
        {
            var data = db.Registrations.ToList();
            return View(data);
        } 
        [HttpPost]
        public ActionResult Index(Registration search)
        {
            if (search != null)
            {
                var row = db.Registrations.ToList();

                if (!string.IsNullOrEmpty(search.Name))
                {
                    row = db.Registrations.Where(x => x.Name.Contains(search.Name)).ToList();
                }
                if (!string.IsNullOrEmpty(search.Email))
                {
                    row = db.Registrations.Where(x => x.Email.Contains(search.Email)).ToList();
                }
                return View(row);
            }
            else
            {
                return RedirectToAction("Index");
            }
        } 
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Registration registration)
        {
            db.Registrations.Add(registration);
            db.SaveChanges();
            return RedirectToAction("Index");
        } 
        [HttpGet]
        public ActionResult Edit(int? id)
        {
            Registration registration = db.Registrations.Find(id);
      
            return View(registration);
        }

        [HttpPost]
        public ActionResult Edit(Registration registration)
        {
            db.Entry(registration).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");

          
        }   
        [HttpGet]
        public ActionResult Delete(int id)
        {
            Registration registration = db.Registrations.Find(id);
            db.Registrations.Remove(registration); 
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}