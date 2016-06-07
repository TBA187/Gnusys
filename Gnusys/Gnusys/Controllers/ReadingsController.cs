using Gnusys.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace Gnusys.Controllers
{
    public class ReadingsController : Controller
    {
        GnysusEFModel DB = new GnysusEFModel();
        // GET: Readings
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AddReadings()
        {
            return View();
        }
        //public ActionResult Overview()
        //{
        //    return DB.EmployeePatients.ToList(p=>p.EmployeeID);

        //}
        [HttpPost]
        public ActionResult AddReadings(int OxygenSaturation_input, int Pulse_input)
        {
            int userid = int.Parse(Session["ID"].ToString());
            Device d = DB.Device.FirstOrDefault(p => p.PatientID == userid);
            DeviceLine dl = new DeviceLine() { PatientID = userid, DeviceID = d.ID };
            Readings r = new Readings() { Pulse = Pulse_input, OxygenSaturation = OxygenSaturation_input, Date = DateTime.Now};
            r.DeviceLine.Add(dl);            
            DB.Readings.Add(r);
            DB.SaveChanges();
            Helpers.AdvProg adv = new Helpers.AdvProg();
            adv.CheckForSuddenDropOrRise(r, userid);
            return View();
        }
    }
}