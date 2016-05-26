namespace Gnusys.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DeviceLine")]
    public partial class DeviceLine
    {
        [Required]
        [StringLength(1)]
        public string DeviceID { get; set; }

        public int PatientID { get; set; }

        public int ReadingID { get; set; }

        [Key]
        [MaxLength(1)]
        public byte[] pk { get; set; }

        public virtual Device Device { get; set; }

        public virtual Readings Readings { get; set; }
    }
}
