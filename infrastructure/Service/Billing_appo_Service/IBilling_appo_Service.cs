using APP_DAL.Models;
using infrastructure.DTOs.AppointmentDtos;
using infrastructure.DTOs.Billing_appo_Dtos;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infrastructure.Service.Billing_appo_Service
{
    public interface IBilling_appo_Service
    {
        void add(Billing_appo_DtosAdd billing_Appo_DtosAdd);
        void Delete(Billing_appo_DtosGet billing_Appo_DtosGet);
        Billing_appo_DtosGet Get(int id);
        IEnumerable<Billing_appo_DtosGet> GetAll();
        public void MakeAppointment_billing(AppointmentDtoAdd appointmentDtoAdd,int amount);
        public void UpdateBilling(int patientId, int doctorId, DateTime date);
        public IEnumerable<Billing_appo_DtosGet> GetBillingPayedOrPending(int type);

    }
}
