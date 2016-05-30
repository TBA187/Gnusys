using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using GnusysMVC.Models;

namespace GnusysMVC.Controllers
{
    public class ReadingsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Readings
        public ActionResult Index()
        {
            return View();
        }

        // GET: Readings/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Readings readings = db.Readings.Find(id);
            if (readings == null)
            {
                return HttpNotFound();
            }
            return View(readings);
        }

        // GET: Readings/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Readings/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,OxygenSaturation,Pulse,ReadingTime,User,Device")] Readings readings)
        {
            if (ModelState.IsValid)
            {
                db.Readings.Add(readings);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(readings);
        }

        // GET: Readings/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Readings readings = db.Readings.Find(id);
            if (readings == null)
            {
                return HttpNotFound();
            }
            return View(readings);
        }

        // POST: Readings/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,OxygenSaturation,Pulse,ReadingTime,User,Device")] Readings readings)
        {
            if (ModelState.IsValid)
            {
                db.Entry(readings).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(readings);
        }

        // GET: Readings/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Readings readings = db.Readings.Find(id);
            if (readings == null)
            {
                return HttpNotFound();
            }
            return View(readings);
        }

        // POST: Readings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Readings readings = db.Readings.Find(id);
            db.Readings.Remove(readings);
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
