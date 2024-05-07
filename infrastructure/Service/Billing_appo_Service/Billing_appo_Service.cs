using APP_DAL.Models;
using APP_DAL.Repo.AppointmentRepo;
using APP_DAL.Repo.Bliling_Appo_Repo;
using AutoMapper;
using infrastructure.DTOs.AppointmentDtos;
using infrastructure.DTOs.Billing_appo_Dtos;
using infrastructure.Service.AppointmentSecrvice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infrastructure.Service.Billing_appo_Service
{
    public class Billing_appo_Service : IBilling_appo_Service
    {
        private readonly IBilling_Appo_Repo _billing_Appo_Repo;
        private readonly IAppointmentRepo _appointmentRepo;
        private readonly IMapper _mapper;

        public Billing_appo_Service
            (IBilling_Appo_Repo billing_Appo_Repo, IAppointmentRepo appointmentRepo, IMapper mapper)
        {
            _billing_Appo_Repo = billing_Appo_Repo;
            _appointmentRepo = appointmentRepo;
            _mapper = mapper;
        }
        public void add(Billing_appo_DtosAdd billing_Appo_DtosAdd)
        {
            var bill = new Billing_appointment() 
            {
                Amount= billing_Appo_DtosAdd.Amount,
                Date_Time= billing_Appo_DtosAdd.Date_Time,
                Type= billing_Appo_DtosAdd.Type,
                AppointmentId = billing_Appo_DtosAdd.AppointmentId
      
            };
            _billing_Appo_Repo.Add(bill);
        }
        public void Delete(Billing_appo_DtosGet billing_Appo_DtosGet)
        {
            var bill = new Billing_appointment()
            {
                Amount = billing_Appo_DtosGet.Amount,
                Date_Time = billing_Appo_DtosGet.Date_Time,
                Type = billing_Appo_DtosGet.Type,
                AppointmentId = billing_Appo_DtosGet.AppointmentId,
                Id= billing_Appo_DtosGet.Id 
            };
            _billing_Appo_Repo.Delete(bill);

        }

        public Billing_appo_DtosGet Get(int id)
        {
            var biil = _billing_Appo_Repo.GetById(id);
            if (biil == null)return null;
            return new Billing_appo_DtosGet() 
            {
                Amount = biil.Amount,
                AppointmentId=biil.AppointmentId,

                Id=biil.Id,
                Date_Time=biil.Date_Time,
                Type = biil.Type,
            };
        }
        public IEnumerable<Billing_appo_DtosGet> GetAll()
        {
            var bill = _billing_Appo_Repo.GetAll();
            return bill.Select(x=> new Billing_appo_DtosGet
            {
                Date_Time = x.Date_Time,
                Amount = x.Amount,
                AppointmentId=x.AppointmentId,
                Id=x.Id,
                Type = x.Type,
            }).ToList(); 
        }
        public void MakeAppointment_billing(AppointmentDtoAdd appointmentDtoAdd, int amount)
        {
            var appo = new Appointment() 
            {
                Add_By = appointmentDtoAdd.Add_By,
                Date_time= DateTime.Now,
                DoctorId= appointmentDtoAdd.DoctorId,
                ClinicId= appointmentDtoAdd.ClinicId,
                PatientId= appointmentDtoAdd.PatientId,
            };
            //_mapper.Map<Appointment>(appointmentDtoAdd);
            _appointmentRepo.Add(appo);
            var billing = new Billing_appointment 
            { 
                Date_Time= DateTime.Now,
                Amount= amount,
                AppointmentId=appo.Id,
                Type= 0,
            };
            _billing_Appo_Repo.Add(billing);
        }
        public void UpdateBilling(int patientId, int doctorId, DateTime date)
        {
            _billing_Appo_Repo.UpdateBilling(patientId, doctorId, date);
        }

        public IEnumerable<Billing_appo_DtosGet> GetBillingPayedOrPending(int type)
        {
           var bill = _billing_Appo_Repo.GetBillingPayedOrPending(type);

            return bill.Select(x => new Billing_appo_DtosGet
            {
                Date_Time = x.Date_Time,
                Amount = x.Amount,
                AppointmentId = x.AppointmentId,
                Id = x.Id,
                Type = x.Type,
            }).ToList();



        }
    }
}
