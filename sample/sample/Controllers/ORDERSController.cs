using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using sample.Models;

namespace sample.Controllers
{
    public class ORDERSController : Controller
    {
        private WebContext db = new WebContext();

        // GET: ORDERS
        public ActionResult Index()
        {
            return View(db.ORDERs.ToList());
        }

        // GET: ORDERS/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ORDERS oRDERS = db.ORDERs.Find(id);
            if (oRDERS == null)
            {
                return HttpNotFound();
            }
            return View(oRDERS);
        }

        // GET: ORDERS/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ORDERS/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ORD_NUM,ORD_AMOUNT,ADVANCE_AMOUNT,ORD_DATE,CUST_CODE,AGENT_CODE,ORD_DESCRIPTION")] ORDERS oRDERS)
        {
            if (ModelState.IsValid)
            {
                db.ORDERs.Add(oRDERS);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(oRDERS);
        }

        // GET: ORDERS/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ORDERS oRDERS = db.ORDERs.Find(id);
            if (oRDERS == null)
            {
                return HttpNotFound();
            }
            return View(oRDERS);
        }

        // POST: ORDERS/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ORD_NUM,ORD_AMOUNT,ADVANCE_AMOUNT,ORD_DATE,CUST_CODE,AGENT_CODE,ORD_DESCRIPTION")] ORDERS oRDERS)
        {
            if (ModelState.IsValid)
            {
                db.Entry(oRDERS).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(oRDERS);
        }

        // GET: ORDERS/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ORDERS oRDERS = db.ORDERs.Find(id);
            if (oRDERS == null)
            {
                return HttpNotFound();
            }
            return View(oRDERS);
        }

        // POST: ORDERS/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            ORDERS oRDERS = db.ORDERs.Find(id);
            db.ORDERs.Remove(oRDERS);
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
