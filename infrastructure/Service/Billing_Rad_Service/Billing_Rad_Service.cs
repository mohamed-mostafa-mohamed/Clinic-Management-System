
using APP_DAL.Models;
using APP_DAL.Repo.Billing_Rad_Repo;
using APP_DAL.Repo.Bliling_Appo_Repo;
using APP_DAL.Repo.Patient_Rad_Repo;
using infrastructure.DTOs.Billing_Lab_Dtos;
using infrastructure.DTOs.Billing_Rad_Dtos;
using infrastructure.DTOs.Patient_Lab_Dtos;
using infrastructure.DTOs.Patient_Rad_Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infrastructure.Service.Billing_Rad_Service
{
    public class Billing_Rad_Service : IBilling_Rad_Service
    {
        private readonly IBilling_Rad_Repo _billing_Rad_Repo;
        private readonly IPatient_Rad_Repo _patient_Rad_Repo;

        public Billing_Rad_Service(IBilling_Rad_Repo billing_Rad_Repo,IPatient_Rad_Repo patient_Rad_Repo)
        {
            _billing_Rad_Repo = billing_Rad_Repo;
            _patient_Rad_Repo = patient_Rad_Repo;
        }
        public void add(Billing_Rad_DtoAdd billing_Rad_DtoAdd)
        {
            var bill = new Billing_Rad()
            {
                Amount = billing_Rad_DtoAdd.Amount,
                Date_Time = billing_Rad_DtoAdd.Date_Time,
                RadiologyId = billing_Rad_DtoAdd.RadiologyId,
                Type = billing_Rad_DtoAdd.Type
            };
            _billing_Rad_Repo.Add(bill);
        }

        public void Delete(int id)
        {
            var bill = _billing_Rad_Repo.GetById(id);
            _billing_Rad_Repo.Delete(bill);
        }

        public Billing_Rad_DtoGet Get(int id)
        {
            var bill = _billing_Rad_Repo.GetById(id);
            return new Billing_Rad_DtoGet()
            {
                Date_Time = bill.Date_Time,
                RadiologyId = bill.RadiologyId,
                Type = bill.Type,
                Id = bill.Id,
                Amount = bill.Amount
            };
        }

        public IEnumerable<Billing_Rad_DtoGet> GetAll()
        {
            var bill = _billing_Rad_Repo.GetAll();
            return bill.Select(x => new Billing_Rad_DtoGet
            {
                Date_Time = x.Date_Time,
                RadiologyId = x.RadiologyId,
                Type = x.Type,
                Id = x.Id,
                Amount= x.Amount
            }).ToList();
        }
        public void MakeRad_billing(Patient_Rad_DtoAdd patient_Rad_DtoAdd,  int amount)
        {
            var appo = new PatientRadiology()
            {
                PatientId = patient_Rad_DtoAdd.PatientId,
                Add_By = patient_Rad_DtoAdd.Add_By,
                Add_Time = DateTime.Now,
                RadiologyId = patient_Rad_DtoAdd.RadiologyId,
            };
            _patient_Rad_Repo.Add(appo);
            var billing = new Billing_Rad
            {
                Date_Time = DateTime.Now,
                Amount = amount,
                Type = 0,
                 RadiologyId= appo.RadiologyId,
            };
            _billing_Rad_Repo.Add(billing);
        }
        public void UpdateBilling(int patientId, int RabId, DateTime date)
        {
            _billing_Rad_Repo.UpdateBilling(patientId, RabId, date);
        }
        public IEnumerable<Billing_Rad_DtoGet> GetBillingPayedOrPending(int type)
        {
            var bill = _billing_Rad_Repo.GetBillingPayedOrPending(type);
            return bill.Select(x => new Billing_Rad_DtoGet
            {
                Date_Time = x.Date_Time,
                RadiologyId = x.RadiologyId,
                Type = x.Type,
                Id = x.Id,
                Amount = x.Amount
            }).ToList();
        }

    }
}
