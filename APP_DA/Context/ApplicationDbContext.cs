using APP_DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_DAL.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Billing_appointment> Billing_Appointments { get; set; }
        public DbSet<Billing_Lab> Billing_Labs { get; set; }
        public DbSet<Billing_Rad> Billing_Rads { get; set; }
        public DbSet<Clinic> Clinics { get; set; }
        public DbSet<Dignosis> Dignoses { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Lab> Labs { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<PatientDignosis> PatientDignoses { get; set; }
        public DbSet<PatientLab> PatientLabs { get; set; }
        public DbSet<PatientRadiology> PatientRadiologies { get; set; }
        public DbSet<Radiology> Radiologies { get; set; }

    }
}
