using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Gnusys.Models;

namespace Gnusys.Controllers
{
    public class PatientController : Controller
    {
        GnysusEFModel DB = new GnysusEFModel();

        // GET: Patient
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Patients()
        {
            return View();
        }

        public ActionResult ShowPatients()
        {
            return View();
        }

        public ActionResult ShowPatients(int id)
        {
            var GetReadings = (from a in DB.DeviceLine
                               where a.PatientID == id
                               join b in DB.Readings on a.ReadingID equals b.ID
                               join c in DB.Patient on a.PatientID equals c.ID
                               select new { b, c }).ToList();

            ViewBag.ShowPatients = GetReadings;
            return View();
        }
    }
}