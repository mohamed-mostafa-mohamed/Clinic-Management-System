using APP_DAL.Context;
using APP_DAL.Models;
using APP_DAL.Repo.GenericRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace APP_DAL.Repo.Bliling_Appo_Repo
{
    public class Billing_Appo_Repo : IBilling_Appo_Repo, IGeneric<Billing_appointment>
    {
        private readonly ApplicationDbContext _dbContext;

        public Billing_Appo_Repo(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public  void Add(Billing_appointment entity)
        {
                  _dbContext.Add(entity);
                  _dbContext.SaveChanges();
        }

        public async Task AddB(Billing_appointment entity)
        {
           await _dbContext.AddAsync(entity);
           await _dbContext.SaveChangesAsync();
        }

        public void Delete(Billing_appointment entity)
        {
            _dbContext.Remove(entity);
            _dbContext.SaveChanges();
        }

        public IEnumerable<Billing_appointment> GetAll()
        {
            return _dbContext.Set<Billing_appointment>().ToList();
        }

        public Billing_appointment GetById(int id)
        {
            var bil= _dbContext.Billing_Appointments.Find(id);
            if(bil==null)return null;
            return bil;
        }
        //public async Task MakeAppointment_billing(Appointment appointment,int type,int amount)
        //{
        //    var appo = _dbContext.Add<Appointment>(appointment);
        //    var bill = new Billing_appointment() 
        //    {
        //        AppointmentId = appointment.Id,
        //        Date_Time= DateTime.Now,
        //        Amount = amount,
        //        Type = type,
        //    };
        //    _dbContext.Billing_Appointments.Add(bill);
        //    _dbContext.SaveChanges();
        //}
        public void UpdateBilling(int patientId, int doctorId, DateTime date)
        {
            var billing = (from billingAppointment in _dbContext.Billing_Appointments
                           join appointment in _dbContext.Appointments
                           on billingAppointment.AppointmentId equals appointment.Id
                           where appointment.DoctorId == doctorId &&
                                 appointment.Date_time == date &&
                                 appointment.PatientId == patientId
                           select billingAppointment)
                          .FirstOrDefault();

            if (billing != null)
            {
                billing.Type = 1;
                _dbContext.SaveChanges();
            }
        }

        public IEnumerable<Billing_appointment> GetBillingPayedOrPending (int type)
        {
            var bill = _dbContext.Billing_Appointments
      .Where(b =>  b.Type == type)
      .Select(b => b)
      .ToList();
           return bill;
        }



    }
}
