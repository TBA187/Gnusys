using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Gnusys.Models;

namespace Gnusys.Controllers
{
    public class AdminController : Controller
    {
        GnysusEFModel DB = new GnysusEFModel();
        public ActionResult Login()
        {
            return View();
        }
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        // GET: Admin/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/Create
        public ActionResult Create()
        {
            return View();
        }
        [HttpGet]
        public ActionResult ConnectDevice()
        {
            var Devices = DB.Set<Device>();
            var Patients = DB.Set<Patient>();
            ViewBag.Devices = Devices.ToList();
            ViewBag.Patients = Patients.ToList();
            return View();
        }
        [HttpPost]
        public ActionResult ConnectDevice(string DeviceSelection, int PatientSelection)
        {
            Device getdevice = DB.Device.FirstOrDefault(p => p.ID == DeviceSelection);
            getdevice.PatientID = PatientSelection;
            DB.Entry(getdevice).State = System.Data.Entity.EntityState.Modified;
            DB.SaveChanges();
            var Devices = DB.Set<Device>();
            var Patients = DB.Set<Patient>();
            ViewBag.Devices = Devices.ToList();
            ViewBag.Patients = Patients.ToList();
            return View();
        }
        // POST: Admin/Create
        [HttpPost]
        public ActionResult Index(string Name, string SurName, string CPRno, string Password, string RPassword, string DDLLevel)
        {
            if (Password == RPassword)
            {
                string Hash = Password;
                if (DDLLevel == "Klinikker")
                {
                    Employee E = new Employee { FirstName = Name, SurName = SurName, CPRno = int.Parse(CPRno), Password = Hash };
                    DB.Employee.Add(E);
                    DB.SaveChanges();
                    return View();
                }
                else if (DDLLevel == "Patient")
                {
                    Patient P = new Patient { ForName = Name, SurName = SurName, CPRno = int.Parse(CPRno), Password = Hash };
                    DB.Patient.Add(P);
                    DB.SaveChanges();
                    return View();
                }
                else
                {
                    return View();
                }
            }
            else
            {
                return View();
            }
        }

        // GET: Admin/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Admin/Edit/5
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

        // GET: Admin/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Admin/Delete/5
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
