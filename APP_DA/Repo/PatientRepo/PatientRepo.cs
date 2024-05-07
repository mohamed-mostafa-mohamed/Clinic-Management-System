using APP_DAL.Context;
using APP_DAL.Models;
using APP_DAL.Repo.GenericRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_DAL.Repo.PatientRepo
{
    public class PatientRepo : IPatientRepo, IGeneric<Patient>
    {
        private readonly ApplicationDbContext _context;

        public PatientRepo(ApplicationDbContext context)
        {
            _context = context;
        }
        public void Add(Patient entity)
        {
            _context.Patients.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(Patient entity)
        {
            _context.Remove(entity);
            _context.SaveChanges();
        }

        public IEnumerable<Patient> GetAll()
        {
           return _context.Patients.ToList();
        }

        public Patient GetById(int id)
        {
          return _context.Set<Patient>().Find(id); 
        }
    }
}
