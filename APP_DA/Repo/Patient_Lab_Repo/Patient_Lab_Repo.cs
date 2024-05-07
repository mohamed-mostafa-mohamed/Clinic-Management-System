using APP_DAL.Context;
using APP_DAL.Models;
using APP_DAL.Repo.GenericRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_DAL.Repo.Patient_Lab_Repo
{
    public class Patient_Lab_Repo : IGeneric<PatientLab>, IPatient_Lab_Repo
    {
        private readonly ApplicationDbContext _dbContext;

        public Patient_Lab_Repo(ApplicationDbContext dbContext)
        {
           _dbContext = dbContext;
        }
        public void Add(PatientLab entity)
        {
            _dbContext.Add(entity);
            _dbContext.SaveChanges();
        }

        public void Delete(PatientLab entity)
        {
            _dbContext.Remove(entity);
            _dbContext.SaveChanges();
        }

        public IEnumerable<PatientLab> GetAll()
        {
           return _dbContext.Set<PatientLab>().ToList();
        }

        public PatientLab GetById(int id)
        {
            var lab= _dbContext.PatientLabs.SingleOrDefault(l => l.Id == id);
            if (lab == null) return null;
            return lab;

        }
    }
}
