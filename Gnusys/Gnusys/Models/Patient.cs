namespace Gnusys.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Patient")]
    public partial class Patient
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Patient()
        {
            Device = new HashSet<Device>();
            EmployeePatients = new HashSet<EmployeePatients>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PatientID { get; set; }

        [Required]
        [StringLength(1)]
        public string Name { get; set; }

        [Required]
        [StringLength(1)]
        public string SurName { get; set; }

        public int CPRno { get; set; }

        [Required]
        [StringLength(1)]
        public string Password { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Device> Device { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmployeePatients> EmployeePatients { get; set; }
    }
}
