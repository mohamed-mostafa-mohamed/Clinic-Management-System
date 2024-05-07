using APP_DAL.Models;
using APP_DAL.Repo.GenericRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_DAL.Repo.Bliling_Appo_Repo
{
    public interface IBilling_Appo_Repo:IGeneric<Billing_appointment>
    {
        Task AddB(Billing_appointment entity);
        void UpdateBilling(int patientId, int doctorId, DateTime date);
        public IEnumerable<Billing_appointment> GetBillingPayedOrPending(int type);



    }
}
