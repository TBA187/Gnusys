using Gnusys.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;
using System.Web.Mvc;
using System.Security.Cryptography;

namespace Gnusys
{
    /// <summary>
    /// Summary description for AndroidWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]

    public class AndroidWebService : System.Web.Services.WebService
    {
        GnysusEFModel DB = new GnysusEFModel();

        [WebMethod]
        [ScriptMethod(UseHttpGet=true)]
        public string AuthenticateLogin(int cpr, string password)
        {
            
            string Hash = password;
            //  string Hash = HashPassword(password);

            var Patientlogin = DB.Patient.FirstOrDefault(p => p.CPRno == cpr && p.Password == Hash);

            if (Patientlogin != null)
            {
                return "ok";
            }
            else
            {
                return "Fejl";
            }
                          
        }

        [WebMethod]
        [ScriptMethod(UseHttpGet = true)]
        public string AddReadings(int OxygenSaturation, int pulse, int cpr)
        {
            Patient patient = DB.Patient.FirstOrDefault(p => p.CPRno == cpr);
            Device d = DB.Device.FirstOrDefault(p => p.PatientID == patient.ID);
            DeviceLine dl = new DeviceLine() { PatientID = patient.ID, DeviceID = d.ID };
            Readings r = new Readings() { Pulse = pulse, OxygenSaturation = OxygenSaturation, Date = DateTime.Now };
            r.DeviceLine.Add(dl);
            DB.Readings.Add(r);
            DB.SaveChanges();
            
        
            return "ok";
        }

    }
}
