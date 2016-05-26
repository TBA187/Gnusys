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
    public class DeviceHistoriesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: DeviceHistories
        public ActionResult Index()
        {
            return View(db.DeviceHistories.ToList());
        }

        // GET: DeviceHistories/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DeviceHistory deviceHistory = db.DeviceHistories.Find(id);
            if (deviceHistory == null)
            {
                return HttpNotFound();
            }
            return View(deviceHistory);
        }

        // GET: DeviceHistories/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DeviceHistories/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Device,User,StartDate,EndDate")] DeviceHistory deviceHistory)
        {
            if (ModelState.IsValid)
            {
                db.DeviceHistories.Add(deviceHistory);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(deviceHistory);
        }

        // GET: DeviceHistories/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DeviceHistory deviceHistory = db.DeviceHistories.Find(id);
            if (deviceHistory == null)
            {
                return HttpNotFound();
            }
            return View(deviceHistory);
        }

        // POST: DeviceHistories/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Device,User,StartDate,EndDate")] DeviceHistory deviceHistory)
        {
            if (ModelState.IsValid)
            {
                db.Entry(deviceHistory).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(deviceHistory);
        }

        // GET: DeviceHistories/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DeviceHistory deviceHistory = db.DeviceHistories.Find(id);
            if (deviceHistory == null)
            {
                return HttpNotFound();
            }
            return View(deviceHistory);
        }

        // POST: DeviceHistories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DeviceHistory deviceHistory = db.DeviceHistories.Find(id);
            db.DeviceHistories.Remove(deviceHistory);
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
