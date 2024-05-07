using APP_DAL.Context;
using APP_DAL.Models;
using APP_DAL.Repo.GenericRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_DAL.Repo.Patient_Rad_Repo
{
    public class Patient_Rad_Repo : IPatient_Rad_Repo, IGeneric<PatientRadiology>
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public Patient_Rad_Repo(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        public void Add(PatientRadiology entity)
        {
            _applicationDbContext.Add(entity);
            _applicationDbContext.SaveChanges();
        }

        public void Delete(PatientRadiology entity)
        {
            _applicationDbContext.Remove(entity);
            _applicationDbContext.SaveChanges();
        }

        public IEnumerable<PatientRadiology> GetAll()
        {
         return _applicationDbContext.Set<PatientRadiology>().ToList();

        }

        public PatientRadiology GetById(int id)
        {
            var pat= _applicationDbContext.PatientRadiologies.SingleOrDefault(p => p.Id == id);
            if (pat == null) return null;
            return pat;
        }
    }
}
