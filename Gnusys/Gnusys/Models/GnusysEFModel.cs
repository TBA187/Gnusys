namespace Gnusys.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class GnusysEFModel : DbContext
    {
        public GnusysEFModel()
            : base("name=GnusysEFModel")
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

            modelBuilder.Entity<Device>()
                .HasMany(e => e.DeviceLine)
                .WithRequired(e => e.Device)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DeviceLine>()
                .Property(e => e.DeviceID)
                .IsUnicode(false);

            modelBuilder.Entity<DeviceLine>()
                .Property(e => e.pk)
                .IsFixedLength();

            modelBuilder.Entity<Employee>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.SurName)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.EmployeePatients)
                .WithRequired(e => e.Employee)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Patient>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Patient>()
                .Property(e => e.SurName)
                .IsUnicode(false);

            modelBuilder.Entity<Patient>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<Patient>()
                .HasMany(e => e.Device)
                .WithRequired(e => e.Patient)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Patient>()
                .HasMany(e => e.EmployeePatients)
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
