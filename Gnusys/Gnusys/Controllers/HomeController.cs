using Gnusys.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Gnusys.Controllers
{
    public class HomeController : Controller
    {
        GnusysEFModel DB = new GnusysEFModel();

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        // GET: Home/Logud
        public ActionResult Logud()
        {
            if (Session["user"] != null)
            {
                Session.Abandon();
            }

            return RedirectToAction("Index");
        }

        // Login
        [HttpPost]
        public ActionResult Index(int cpr, string password)
        {
            var login = DB.Patient.FirstOrDefault(p => p.CPRno == cpr && p.Password == password);

            if (login != null)
            {
                Session["user"] = login.Name + " " + login.SurName;
            }
            else
            {
                ViewData["Error"] = "Fejl, kunne ikke logge ind!";
            }
            return View();
        }

        // GET: Home/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Home/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Home/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            return View();
        }

        // GET: Home/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Home/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Home/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Home/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
