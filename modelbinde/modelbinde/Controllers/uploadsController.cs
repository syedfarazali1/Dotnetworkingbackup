using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using modelbinde.Models;

namespace modelbinde.Controllers
{
    public class uploadsController : Controller
    {
        private WebContext db = new WebContext();

        // GET: uploads
        public ActionResult Index()
        {
            return View(db.uploads.ToList());
        }

        // GET: uploads/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            upload upload = db.uploads.Find(id);
            if (upload == null)
            {
                return HttpNotFound();
            }
            return View(upload);
        }

        // GET: uploads/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: uploads/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name")] upload upload)
        {
            if (ModelState.IsValid)
            {
                db.uploads.Add(upload);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(upload);
        }

        // GET: uploads/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            upload upload = db.uploads.Find(id);
            if (upload == null)
            {
                return HttpNotFound();
            }
            return View(upload);
        }

        // POST: uploads/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name")] upload upload)
        {
            if (ModelState.IsValid)
            {
                db.Entry(upload).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(upload);
        }

        // GET: uploads/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            upload upload = db.uploads.Find(id);
            if (upload == null)
            {
                return HttpNotFound();
            }
            return View(upload);
        }

        // POST: uploads/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            upload upload = db.uploads.Find(id);
            db.uploads.Remove(upload);
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
