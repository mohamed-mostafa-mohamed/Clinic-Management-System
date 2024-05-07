using APP_DAL.Context;
using APP_DAL.Models;
using APP_DAL.Repo.GenericRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_DAL.Repo.Billing_Rad_Repo
{
    public class Billing_Rad_Repo:IGeneric<Billing_Rad>,IBilling_Rad_Repo
    {
        private readonly ApplicationDbContext _dbContext;

        public Billing_Rad_Repo(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Add(Billing_Rad entity)
        {
            _dbContext.Add(entity);
            _dbContext.SaveChanges();
        }

        public void Delete(Billing_Rad entity)
        {
            _dbContext.Remove(entity);
            _dbContext.SaveChanges();
        }

        public IEnumerable<Billing_Rad> GetAll()
        {
            return _dbContext.Set<Billing_Rad>().ToList();
        }

        public Billing_Rad GetById(int id)
        {
            var bill = _dbContext.Billing_Rads.Find(id);
            if (bill == null) return null;
            return bill;
        }

        public void UpdateBilling(int patientId, int RabId, DateTime date)
        {
            var billing = (from br in _dbContext.Billing_Rads
                           join pr in _dbContext.PatientRadiologies on br.RadiologyId equals pr.RadiologyId
                           where pr.PatientId == patientId && pr.RadiologyId == RabId && pr.Add_Time == date
                           select br).FirstOrDefault();

            if (billing != null)
            {
                billing.Type = 1;
                _dbContext.SaveChanges();
            }
        }
        public IEnumerable<Billing_Rad> GetBillingPayedOrPending(int type)
        {
            var bill = _dbContext.Billing_Rads
.Where(b => b.Type == type)
.Select(b => b)
.ToList();
             return bill;
        }
    }
}
