namespace Gnusys
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EmployeePatients
    {
    {
        public int EmployeeID { get; set; }

        public int PatientID { get; set; }

        [Key]
        public int pk { get; set; }
    }
}
}
