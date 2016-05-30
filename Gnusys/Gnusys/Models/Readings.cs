namespace Gnusys.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Readings
    {
        [Key]
        [Column(Order = 0)]
        public int Pulse { get; set; }
        [Key]
        [Column(Order = 1)]
        public int OxygenSaturation { get; set; }
        [Key]
        [Column(Order = 2)]
        public DateTime Date { get; set; }
        [Key]
        [Column(Order = 3)]
        public int ID { get; set; }
    }
}
