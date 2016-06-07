namespace WebApplication2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DeviceLine")]
    public partial class DeviceLine
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string DeviceID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PatientID { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ReadingID { get; set; }

        public virtual Device Device { get; set; }

        public virtual Patient Patient { get; set; }

        public virtual Readings Readings { get; set; }
    }
}
