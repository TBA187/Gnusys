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
    }
}