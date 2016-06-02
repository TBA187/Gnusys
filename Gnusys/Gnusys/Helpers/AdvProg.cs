using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Gnusys.Models;
using System.Security.Cryptography;

namespace Gnusys.Helpers
{
    public class AdvProg
    {
        GnysusEFModel DB = new GnysusEFModel();
        public void CheckForSuddenDropOrRise(Readings reading, int patientId)
        {
            double delta = reading.OxygenSaturation / GetAverage(patientId);
            if(delta > 0.90 || delta < 1.10)
            {
                Alert.SendAlert();
            }
        }
        private int GetAverage(int patientId)
        {
            int sum = 0;
            int average;
            var GetReadings = (from a in DB.DeviceLine
                               where a.PatientID == patientId
                               join b in DB.Readings on a.ReadingID equals b.ID
                               join c in DB.Patient on a.PatientID equals c.ID
                               select b).Take(20).ToList();
            foreach (var item in GetReadings)
            {
                sum = sum + item.OxygenSaturation;
            }
            average = sum / GetReadings.Count;
            return average;
        }
    }
}