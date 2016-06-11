using Gnusys.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Security.Cryptography;

namespace Gnusys.Controllers
{
    public class HomeController : Controller
    {
        GnysusEFModel DB = new GnysusEFModel();

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        // GET: Home/Logud
        public ActionResult Logud()
        {
            if (Session["ID"] != null)
            {
                Session.Abandon();
            }

            return RedirectToAction("Index");
        }

        // Login
        [HttpPost]
        public ActionResult Index(int cpr, string password)
        {
            //string Hash = HashPassword(password);

            //VerifyHashedPassword(Hash, password);
           string Hash = password;

            

            var  Patientlogin = DB.Patient.FirstOrDefault(p => p.CPRno == cpr && p.Password == Hash);

              var  Employeelogin = DB.Employee.FirstOrDefault(p => p.CPRno == cpr && p.Password == Hash);

          
            if (Patientlogin != null)
            {
                Session["ID"] = Patientlogin.ID.ToString();
                Session["FirstName"] = Patientlogin.ForName.ToString();
                Session["SurName"] = Patientlogin.SurName.ToString();
                Session["CPRno"] = Patientlogin.CPRno.ToString();
                Session["Type"] = "Patient";
            }
            else if(Employeelogin != null)
            {
                Session["ID"] = Employeelogin.ID.ToString();
                Session["FirstName"] = Employeelogin.FirstName.ToString();
                Session["SurName"] = Employeelogin.SurName.ToString();
                Session["CPRno"] = Employeelogin.CPRno.ToString();
                Session["Type"] = "Employee";
            }
            else
            {
                ViewData["Error"] = "Fejl, kunne ikke logge ind!";
            }

            return View();
        }

        public static string HashPassword(string password)
        {
            byte[] salt;
            byte[] buffer2;
            if (password == null)
            {
                throw new ArgumentNullException("password");
            }
            using (Rfc2898DeriveBytes bytes = new Rfc2898DeriveBytes(password, 0x8, 0x3e8))
            {
                salt = bytes.Salt;
                buffer2 = bytes.GetBytes(0x20);
            }
            byte[] dst = new byte[0x31];
            Buffer.BlockCopy(salt, 0, dst, 1, 0x8);
            Buffer.BlockCopy(buffer2, 0, dst, 0x11, 0x20);
            return Convert.ToBase64String(dst);
        }
        public static bool VerifyHashedPassword(string hashedPassword, string password)
        {
            byte[] buffer4;
            if (hashedPassword == null)
            {
                return false;
            }
            if (password == null)
            {
                throw new ArgumentNullException("password");
            }
            byte[] src = Convert.FromBase64String(hashedPassword);
            if ((src.Length != 0x31) || (src[0] != 0))
            {
                return false;
            }
            byte[] dst = new byte[0x8];
            Buffer.BlockCopy(src, 1, dst, 0, 0x8);
            byte[] buffer3 = new byte[0x20];
            Buffer.BlockCopy(src, 0x11, buffer3, 0, 0x20);
            using (Rfc2898DeriveBytes bytes = new Rfc2898DeriveBytes(password, dst, 0x3e8))
            {
                buffer4 = bytes.GetBytes(0x20);
            }
            return ByteArraysEqual(buffer3, buffer4);
        }

        private static bool ByteArraysEqual(byte[] firstHash, byte[] secondHash)
        {
            int _minHashLength = firstHash.Length <= secondHash.Length ? firstHash.Length : secondHash.Length;
            var xor = firstHash.Length ^ secondHash.Length;
            for (int i = 0; i < _minHashLength; i++)
                xor |= firstHash[i] ^ secondHash[i];
            return 0 == xor;
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
