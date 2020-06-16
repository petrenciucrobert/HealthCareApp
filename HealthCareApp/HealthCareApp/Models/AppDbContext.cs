using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HealthCareApp.Models;

namespace HealthCareApp.Models
{
    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
                
        }

        public DbSet<Patient> Patients { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<PatientCheckUp> PatientCheckup { get; set; }
        
        public DbSet<Medicine> Medicine { get; set; }
        public DbSet<MedicineCategory> MedicineCategory { get; set; }
        public DbSet<Bed> Bed { get; set; }
        public DbSet<BedCategory> BedCategory { get; set; }
        public DbSet<BedAllotment> BedAllotment { get; set; }
        public DbSet<LaboratoryTest> LaboratoryTest { get; set; }
        public DbSet<LaboratoryTestCategory> LaboratoryTestCategory { get; set; }
        public DbSet<PatientLaboratoryTest> PatientLaboratoryTest { get; set; }
        public DbSet<HealthCareApp.Models.Nurse> Nurse { get; set; }

        public DbSet<HealthCareApp.Models.Receptionist> Receptionist { get; set; }

        public DbSet<HealthCareApp.Models.CleaningStaff> CleaningStaff { get; set; }

        public DbSet<Expense> Expense { get; set; }
        public DbSet<ExpenseCategory> ExpenseCategory { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Doctor>().ToTable("Doctors");
            modelBuilder.Entity<Patient>().ToTable("Patients");
            modelBuilder.Entity<PatientCheckUp>().ToTable("PatientCheckup");

        }

        

    }
}
