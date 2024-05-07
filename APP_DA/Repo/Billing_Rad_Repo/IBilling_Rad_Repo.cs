using APP_DAL.Models;
using APP_DAL.Repo.GenericRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_DAL.Repo.Billing_Rad_Repo
{
    public interface IBilling_Rad_Repo : IGeneric<Billing_Rad>
    {
        public void UpdateBilling(int patientId, int RabId, DateTime date);
        public IEnumerable<Billing_Rad> GetBillingPayedOrPending(int type);
    }
}
