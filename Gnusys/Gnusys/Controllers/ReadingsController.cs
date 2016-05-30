using Gnusys.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Gnusys.Controllers
{
    public class ReadingsController : Controller
    {
        GnusysEFModel DB = new GnusysEFModel();
        // GET: Readings
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AddReadings()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddReadings(int OxygenSaturation_input, int Pulse_input)
        {
            return View();
        }
    }
}