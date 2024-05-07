using APP_DAL.Context;
using APP_DAL.Models;
using APP_DAL.Repo.GenericRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_DAL.Repo.billing_Lab_Repo
{
    public class billing_Lab_Repo : IGeneric<Billing_Lab>, Ibilling_Lab_Repo
    {
        private readonly ApplicationDbContext _dbContext;

        public billing_Lab_Repo(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Add(Billing_Lab entity)
        {
            _dbContext.Add(entity);
            _dbContext.SaveChanges();
        }

        public void Delete(Billing_Lab entity)
        {
            _dbContext.Remove(entity);
            _dbContext.SaveChanges();
        }

        public IEnumerable<Billing_Lab> GetAll()
        {
           return _dbContext.Set<Billing_Lab>().ToList();
        }

        public Billing_Lab GetById(int id)
        {
            var bill =_dbContext.Billing_Labs.Find(id);
            if (bill == null) return null;
            return bill;
        }

        public void UpdateBilling(int patientId, int labId, DateTime date)
        {
            var billing = (from bl in _dbContext.Billing_Labs
                           join pl in _dbContext.PatientLabs on bl.LabId equals pl.LabId
                           where pl.PatientId == patientId && pl.LabId == labId && pl.Add_Time == date
                           select bl).FirstOrDefault();

            if (billing != null)
            {
                billing.Type = 1;
                _dbContext.SaveChanges();
            }
        }
        public IEnumerable<Billing_Lab> GetBillingPayedOrPending(int type)
        {
            var bill = _dbContext.Billing_Labs
 .Where(b => b.Type == type)
 .Select(b => b)
 .ToList();
             return bill;
        }

    }
}
