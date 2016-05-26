﻿using System;
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
    public class Device
    {
        public string ID { get; set; }
        public int User { get; set; }
    }
    public class UserInfo
    {
        public int ID { get; set; }
        public string Fornavn { get; set; }
        public string Efternavn { get; set; }
        public int User { get; set; }
        public string CPR { get; set; }
        public int Accesslevel { get; set; }
    }
    public class DeviceHistory
    {
        public int ID { get; set; }
        public string Device { get; set; }
        public int User { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}