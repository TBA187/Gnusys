namespace Gnusys.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class GnusysEFModel : DbContext
    {
        public GnusysEFModel()
            : base("name=GnusysEFModel1")
        {
        }

        public virtual DbSet<Device> Device { get; set; }
        public virtual DbSet<DeviceLine> DeviceLine { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<EmployeePatients> EmployeePatients { get; set; }
        public virtual DbSet<Patient> Patient { get; set; }
        public virtual DbSet<Readings> Readings { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Device>()
                .Property(e => e.ID)
                .IsUnicode(false);
        }
    }
}
