using infrastructure.DTOs.Billing_Lab_Dtos;
using infrastructure.DTOs.Billing_Rad_Dtos;
using infrastructure.DTOs.Patient_Rad_Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infrastructure.Service.Billing_Rad_Service
{
    public interface IBilling_Rad_Service
    {
        void add(Billing_Rad_DtoAdd billing_Lab_Dto_Add);
        void Delete(int id);
        Billing_Rad_DtoGet Get(int id);
        IEnumerable<Billing_Rad_DtoGet> GetAll();
        public void MakeRad_billing(Patient_Rad_DtoAdd patient_Rad_DtoAdd,int amount);
        public void UpdateBilling(int patientId, int RabId, DateTime date);

        public IEnumerable<Billing_Rad_DtoGet> GetBillingPayedOrPending(int type);
    }
}
