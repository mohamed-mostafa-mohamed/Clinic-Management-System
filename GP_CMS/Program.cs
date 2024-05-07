
using APP_DAL.Context;
using APP_DAL.Models;
using APP_DAL.Repo.AppointmentRepo;
using APP_DAL.Repo.billing_Lab_Repo;
using APP_DAL.Repo.Billing_Rad_Repo;
using APP_DAL.Repo.Bliling_Appo_Repo;
using APP_DAL.Repo.ClinicRepo;
using APP_DAL.Repo.DignosisRepo;
using APP_DAL.Repo.DoctorRepo;
using APP_DAL.Repo.LabRepo;

using APP_DAL.Repo.Patient_Dig_Repo;
using APP_DAL.Repo.Patient_Lab_Repo;
using APP_DAL.Repo.Patient_Rad_Repo;
using APP_DAL.Repo.PatientRepo;
using APP_DAL.Repo.RadRepo;
using infrastructure.MappingProfile;
using infrastructure.Service.AppointmentSecrvice;
using infrastructure.Service.Billing_appo_Service;
using infrastructure.Service.Billing_Lab_Service;
using infrastructure.Service.Billing_Rad_Service;
using infrastructure.Service.ClinicService;
using infrastructure.Service.DignosisService;
using infrastructure.Service.DoctorService;
using infrastructure.Service.LabService;

using infrastructure.Service.Patient_Dig_Service;
using infrastructure.Service.Patient_Lab_Service;
using infrastructure.Service.Patient_Rad_Service;
using infrastructure.Service.PatientService;
using infrastructure.Service.RadService;
using Microsoft.EntityFrameworkCore;

namespace GP_CMS
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddDbContext<ApplicationDbContext>(op => op.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddScoped<IDoctorService, DoctorService>();
            builder.Services.AddScoped<IDoctorRepository, DoctorRepository>();
            builder.Services.AddScoped<IPatientService, PatientService>();
            builder.Services.AddScoped<IPatientRepo, PatientRepo>();
            builder.Services.AddScoped<ILabService, LabService>();
            builder.Services.AddScoped<ILabRepo, LabRepo>();
            builder.Services.AddScoped<IClinicService, ClinicService>();
            builder.Services.AddScoped<IClinicRepo, ClinicRepo>();
            builder.Services.AddScoped<IRadService, RadService>();
            builder.Services.AddScoped<IRadRepo, RadRepo>();
            builder.Services.AddScoped<IDignosisService, DignosisService>();
            builder.Services.AddScoped<IDignosisRepo, DignosisRepo>();
            builder.Services.AddScoped<IAppointmentSecrvice, AppointmentSecrvice>();
            builder.Services.AddScoped<IAppointmentRepo, AppointmentRepo>();
            builder.Services.AddScoped<IBilling_appo_Service, Billing_appo_Service>();
            builder.Services.AddScoped<IBilling_Appo_Repo, Billing_Appo_Repo>();
            builder.Services.AddScoped<IBilling_Lab_Service, Billing_Lab_Service>();
            builder.Services.AddScoped<Ibilling_Lab_Repo, billing_Lab_Repo>();
            builder.Services.AddScoped<IBilling_Rad_Service, Billing_Rad_Service>();
            builder.Services.AddScoped<IBilling_Rad_Repo, Billing_Rad_Repo>();
            builder.Services.AddScoped<IPatient_Dig_Service, Patient_Dig_Service>();
            builder.Services.AddScoped<IPatient_Dig_Repo, Patient_Dig_Repo>();
            builder.Services.AddScoped<IPatient_Lab_Service, Patient_Lab_Service>();
            builder.Services.AddScoped<IPatient_Lab_Repo, Patient_Lab_Repo>();
            builder.Services.AddScoped<IPatient_Rad_Service, Patient_Rad_Service>();
            builder.Services.AddScoped<IPatient_Rad_Repo, Patient_Rad_Repo>();
            builder.Services.AddAutoMapper(typeof(MappingProfile).Assembly);
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
