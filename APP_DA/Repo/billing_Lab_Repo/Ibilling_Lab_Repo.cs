using APP_DAL.Models;
using APP_DAL.Repo.GenericRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_DAL.Repo.billing_Lab_Repo
{
    public interface Ibilling_Lab_Repo:IGeneric<Billing_Lab>
    {
        public void UpdateBilling(int patientId, int labId, DateTime date);
        public IEnumerable<Billing_Lab> GetBillingPayedOrPending(int type);
    }
}
