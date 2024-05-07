using APP_DAL.Models;
using infrastructure.DTOs.AppointmentDtos;
using infrastructure.DTOs.Billing_appo_Dtos;
using infrastructure.DTOs.Billing_Lab_Dtos;
using infrastructure.DTOs.Patient_Lab_Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infrastructure.Service.Billing_Lab_Service
{
    public interface IBilling_Lab_Service
    {
        void add(Billing_Lab_Dto_Add billing_Lab_Dto_Add);
        void Delete(Billing_Lab_DTO_Get billing_Lab_DTO_Get);
        Billing_Lab_DTO_Get Get(int id);
        IEnumerable<Billing_Lab_DTO_Get> GetAll();
        public void MakeLab_billing(Patient_Lab_DtoAdd patient_Lab_DtoAdd, int amount);
        public void UpdateBilling(int patientId, int labId, DateTime date);
        public IEnumerable<Billing_Lab_DTO_Get> GetBillingPayedOrPending(int type);
    }
}
