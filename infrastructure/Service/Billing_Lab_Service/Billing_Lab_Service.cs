using APP_DAL.Models;
using APP_DAL.Repo.billing_Lab_Repo;
using APP_DAL.Repo.Patient_Lab_Repo;
using infrastructure.DTOs.AppointmentDtos;
using infrastructure.DTOs.Billing_Lab_Dtos;
using infrastructure.DTOs.Patient_Lab_Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infrastructure.Service.Billing_Lab_Service
{
    public class Billing_Lab_Service : IBilling_Lab_Service
    {
        private readonly Ibilling_Lab_Repo _ibilling_Lab_Repo;
        private readonly IPatient_Lab_Repo _patient_Lab_Repo;

        public Billing_Lab_Service(Ibilling_Lab_Repo ibilling_Lab_Repo,IPatient_Lab_Repo patient_Lab_Repo)
        {
            _ibilling_Lab_Repo = ibilling_Lab_Repo;
            _patient_Lab_Repo = patient_Lab_Repo;
        }
        public void add(Billing_Lab_Dto_Add billing_Lab_Dto_Add)
        {
            var bill = new Billing_Lab() 
            {
                Amount= billing_Lab_Dto_Add.Amount,
                Date_Time= billing_Lab_Dto_Add.Date_Time,
                LabId= billing_Lab_Dto_Add.LabId,
                Type= billing_Lab_Dto_Add.Type
            };
            _ibilling_Lab_Repo.Add(bill);
        }

        public void Delete(Billing_Lab_DTO_Get billing_Lab_DTO_Get)
        {
            var bill = new Billing_Lab()
            {
                Amount = billing_Lab_DTO_Get.Amount,
                Date_Time = billing_Lab_DTO_Get.Date_Time,
                LabId = billing_Lab_DTO_Get.LabId,

                Type = billing_Lab_DTO_Get.Type,
                Id= billing_Lab_DTO_Get.Id
            };
            _ibilling_Lab_Repo.Delete(bill);
        }

        public Billing_Lab_DTO_Get Get(int id)
        {
            var bill =_ibilling_Lab_Repo.GetById(id);
            return new Billing_Lab_DTO_Get() 
            {
                Date_Time= bill.Date_Time,
                LabId = bill.LabId,

                Type = bill.Type,
                Id= bill.Id,
                Amount = bill.Amount
            };
        }

        public IEnumerable<Billing_Lab_DTO_Get> GetAll()
        {
            var bill = _ibilling_Lab_Repo.GetAll();
            return bill.Select(x => new Billing_Lab_DTO_Get 
            {
                Date_Time = x.Date_Time,
                LabId = x.LabId,

                Type = x.Type,
                Id= x.Id,
                Amount= x.Amount
                
            }).ToList();
        }
        public void MakeLab_billing(Patient_Lab_DtoAdd patient_Lab_DtoAdd,  int amount)
        {
            var appo = new PatientLab()
            {
                PatientId = patient_Lab_DtoAdd.PatientId,
                Add_By = patient_Lab_DtoAdd.Add_By,
                Add_Time=DateTime.Now,
                LabId= patient_Lab_DtoAdd.LabId,
            };
            _patient_Lab_Repo.Add(appo);
            var billing = new Billing_Lab
            {
                Date_Time= DateTime.Now,
                Amount= amount,
                Type = 0,
                LabId=appo.LabId,
            };
            _ibilling_Lab_Repo.Add(billing);
        }
        public void UpdateBilling(int patientId, int labId, DateTime date)
        {
            _ibilling_Lab_Repo.UpdateBilling(patientId, labId, date);
        }
        public IEnumerable<Billing_Lab_DTO_Get> GetBillingPayedOrPending(int type)
        {
            var bill = _ibilling_Lab_Repo.GetBillingPayedOrPending(type);
            return bill.Select(x => new Billing_Lab_DTO_Get
            {
                Date_Time = x.Date_Time,
                LabId = x.LabId,

                Type = x.Type,
                Id = x.Id,
                Amount = x.Amount

            }).ToList();
        }

    }
}
