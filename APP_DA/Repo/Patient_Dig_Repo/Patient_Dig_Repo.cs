using APP_DAL.Context;
using APP_DAL.Models;
using APP_DAL.Repo.GenericRepo;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_DAL.Repo.Patient_Dig_Repo
{
    public class Patient_Dig_Repo : IGeneric<PatientDignosis>,IPatient_Dig_Repo
    {

        private readonly ApplicationDbContext _dbContext;

        public Patient_Dig_Repo(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Add(PatientDignosis entity)
        {
            _dbContext.Set<PatientDignosis>().Add(entity);
            _dbContext.SaveChanges();
        }

        public void Delete(PatientDignosis entity)
        {
            _dbContext.PatientDignoses.Remove(entity);
            _dbContext.SaveChanges();
        }

        public IEnumerable<PatientDignosis> GetAll()
        {
            return _dbContext.Set<PatientDignosis>().ToList();
        }

        public PatientDignosis GetById(int id)
        {
            var bill = _dbContext.PatientDignoses.SingleOrDefault(x => x.Id == id);
            if (id == 0) return null;
            return bill;
        }
      
    }
}
