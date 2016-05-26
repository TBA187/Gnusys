using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using GnusysMVC.Models;

namespace GnusysMVC.Controllers
{
    public class ReadingsWebAPIController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: api/ReadingsWebAPI
        public IQueryable<Readings> GetReadings()
        {
            return db.Readings;
        }

        // GET: api/ReadingsWebAPI/5
        [ResponseType(typeof(Readings))]
        public IHttpActionResult GetReadings(int id)
        {
            Readings readings = db.Readings.Find(id);
            if (readings == null)
            {
                return NotFound();
            }

            return Ok(readings);
        }

        // PUT: api/ReadingsWebAPI/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutReadings(int id, Readings readings)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != readings.ID)
            {
                return BadRequest();
            }

            db.Entry(readings).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ReadingsExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/ReadingsWebAPI
        [ResponseType(typeof(Readings))]
        public IHttpActionResult PostReadings(Readings readings)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Readings.Add(readings);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = readings.ID }, readings);
        }

        // DELETE: api/ReadingsWebAPI/5
        [ResponseType(typeof(Readings))]
        public IHttpActionResult DeleteReadings(int id)
        {
            Readings readings = db.Readings.Find(id);
            if (readings == null)
            {
                return NotFound();
            }

            db.Readings.Remove(readings);
            db.SaveChanges();

            return Ok(readings);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ReadingsExists(int id)
        {
            return db.Readings.Count(e => e.ID == id) > 0;
        }
    }
}