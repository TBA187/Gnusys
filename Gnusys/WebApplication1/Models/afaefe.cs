namespace WebApplication1.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class afaefe : DbContext
    {
        public afaefe()
            : base("name=afaefe")
        {
        }

        public virtual DbSet<Device> Device { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<EmployeePatients> EmployeePatients { get; set; }
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
                .HasMany(e => e.EmployeePatients)
                .WithRequired(e => e.Employee)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Patient>()
                .HasMany(e => e.EmployeePatients)
                .WithRequired(e => e.Patient)
                .WillCascadeOnDelete(false);

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
