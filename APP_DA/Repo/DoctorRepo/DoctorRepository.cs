using APP_DAL.Context;
using APP_DAL.Models;
using APP_DAL.Repo.GenericRepo;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_DAL.Repo.DoctorRepo
{
    public class DoctorRepository : IGeneric<Doctor>, IDoctorRepository
    {

        public DoctorRepository(ApplicationDbContext dbContext)
        {
            _DbContext = dbContext;
        }

        public ApplicationDbContext _DbContext;

        public IEnumerable<Doctor> GetAll()
        {
            return  _DbContext.Doctors.ToList();
             
        }

        public Doctor GetById(int id)
        {
            return _DbContext.Set<Doctor>().Find(id);
        }

        public void Add(Doctor entity)
        {
            _DbContext.Add(entity);
            _DbContext.SaveChanges();
        }

        public void Delete(Doctor entity)
        {
            _DbContext.Remove(entity);
            _DbContext.SaveChanges();
        }

    }
}
