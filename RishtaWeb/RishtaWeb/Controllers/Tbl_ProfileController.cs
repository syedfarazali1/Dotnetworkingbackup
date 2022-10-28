﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using RishtaWeb.Models;

namespace RishtaWeb.Controllers
{
    public class Tbl_ProfileController : Controller
    {
        private WebContext db = new WebContext();

        // GET: Tbl_Profile
        public ActionResult Index()
        {
            return View(db.Tbl_Profiles.ToList());
        }

        // GET: Tbl_Profile/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tbl_Profile tbl_Profile = db.Tbl_Profiles.Find(id);
            if (tbl_Profile == null)
            {
                return HttpNotFound();
            }
            return View(tbl_Profile);
        }

        // GET: Tbl_Profile/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Tbl_Profile/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Height_education,Work_with,Job_Role,Income,Profile_For,F_Name,L_Name,Gender,Religion,Community,DOB,Country,City,With_Fam,Mar_Status,Diet,Height,Cast,About_Urself,Ph_No,Email,Password,Confrim_Password")] Tbl_Profile tbl_Profile)
        {
            if (ModelState.IsValid)
            {
                db.Tbl_Profiles.Add(tbl_Profile);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tbl_Profile);
        }

        // GET: Tbl_Profile/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tbl_Profile tbl_Profile = db.Tbl_Profiles.Find(id);
            if (tbl_Profile == null)
            {
                return HttpNotFound();
            }
            return View(tbl_Profile);
        }

        // POST: Tbl_Profile/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Height_education,Work_with,Job_Role,Income,Profile_For,F_Name,L_Name,Gender,Religion,Community,DOB,Country,City,With_Fam,Mar_Status,Diet,Height,Cast,About_Urself,Ph_No,Email,Password,Confrim_Password")] Tbl_Profile tbl_Profile)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tbl_Profile).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tbl_Profile);
        }

        // GET: Tbl_Profile/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tbl_Profile tbl_Profile = db.Tbl_Profiles.Find(id);
            if (tbl_Profile == null)
            {
                return HttpNotFound();
            }
            return View(tbl_Profile);
        }

        // POST: Tbl_Profile/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Tbl_Profile tbl_Profile = db.Tbl_Profiles.Find(id);
            db.Tbl_Profiles.Remove(tbl_Profile);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
