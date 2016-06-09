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
        public ActionResult AddPatient()
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
        public ActionResult AddPatient(string empID, string Name, string SurName, string CPRno, string Password, string RPassword, string DDLLevel, string DeviceSelection)
        {

            if (Password == RPassword)
            {
                //try
                //{
                string Hash = Password;
                if (DDLLevel == "Klinikker")
                {
                    Employee E = new Employee { FirstName = Name, SurName = SurName, CPRno = int.Parse(CPRno), Password = Hash };
                    DB.Employee.Add(E);
                    DB.SaveChanges();
                    Response.Write("<script>alert('Klinikeren er tilføjet');</script>");
                    return View();
                }
                else if (DDLLevel == "Patient")
                {
                    Patient P = new Patient { ForName = Name, SurName = SurName, CPRno = int.Parse(CPRno), Password = Hash };

                    //Device getdevice = DB.Device.First(p => p.ID == DeviceSelection);
                    //getdevice.PatientID = 123;
                    //DB.Entry(getdevice).State = System.Data.Entity.EntityState.Modified;

                    DB.Patient.Add(P);
                    DB.SaveChanges();

                    int newPersonID = P.ID;

                    using (var context = new Gnusys.Models.GnysusEFModel())
                    {
                        context.Database.ExecuteSqlCommand("INSERT INTO EmployeePatients(EmployeeID, PatientID) VALUES(" + empID + ", " + newPersonID + ")");
                    }

                    using (var context = new Gnusys.Models.GnysusEFModel())
                    {
                        context.Database.ExecuteSqlCommand("UPDATE Device SET PatientID = " + newPersonID + " WHERE ID = '" + DeviceSelection + "'");
                    }




                    Response.Write("<script>alert('Patient er tilføjet');</script>");
                    return View();
                }
                else
                {
                    return View();
                }
                //}
                //catch
                //{
                //    Response.Write("<script>alert('Fejl, tjek om alle felter er udfyldt korrekt');</script>");
                //}
            }
            else
            {
                return View();
            }
            //return View();



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
        [HttpGet]
        public ActionResult ShowPatients()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ShowPatients(int PatientSelection)
        {
            var GetReadings = (from a in DB.DeviceLine
                               where a.PatientID == PatientSelection
                               join b in DB.Readings on a.ReadingID equals b.ID
                               join c in DB.Patient on a.PatientID equals c.ID
                               select b);
            ViewBag.ShowReadings = GetReadings.ToList();

            return View();
        }
        public ActionResult ConfirmRegistration()
        {
            return View();
        }

    }
}
