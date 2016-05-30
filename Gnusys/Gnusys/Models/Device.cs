namespace Gnusys.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Device")]
    public partial class Device
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(1)]
        public string ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PatientID { get; set; }
    }
}
