namespace Gnusys.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class GnysusEFModel : DbContext
    {
        public GnysusEFModel()
            : base("name=GnysusEFModel")
        {
        }

        public virtual DbSet<Device> Device { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Patient> Patient { get; set; }
        public virtual DbSet<Readings> Readings { get; set; }
        public virtual DbSet<DeviceLine> DeviceLine { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Device>()
                .HasMany(e => e.DeviceLine)
                .WithRequired(e => e.Device)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.Patient)
                .WithMany(e => e.Employee)
                .Map(m => m.ToTable("EmployeePatients").MapLeftKey("EmployeeID").MapRightKey("PatientID"));

            modelBuilder.Entity<Patient>()
                .HasMany(e => e.DeviceLine)
                .WithRequired(e => e.Patient)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Readings>()
                .HasMany(e => e.DeviceLine)
                .WithRequired(e => e.Readings)
                .HasForeignKey(e => e.ReadingID)
                .WillCascadeOnDelete(false);
        }
    }
}
