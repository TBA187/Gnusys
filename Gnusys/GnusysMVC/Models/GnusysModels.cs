using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GnusysMVC.Models
{
    public class Readings
    {
        public int ID { get; set; }
        public int OxygenSaturation { get; set; }
        public int Pulse { get; set; }
        public DateTime ReadingTime { get; set; }
        public int User { get; set; }
        public string Device { get; set; }
    }
}