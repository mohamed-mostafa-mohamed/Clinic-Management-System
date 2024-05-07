using APP_DAL.Context;
using APP_DAL.Models;
using APP_DAL.Repo.GenericRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_DAL.Repo.ClinicRepo
{
    public class ClinicRepo : IClinicRepo, IGeneric<Clinic>
    {
        private readonly ApplicationDbContext _dbContext;

        public ClinicRepo(ApplicationDbContext dbContext )
        {
            _dbContext = dbContext;
        }
        public void Add(Clinic entity)
        {
            _dbContext.Add( entity );
            _dbContext.SaveChanges();
        }

        public void Delete(Clinic entity)
        {
            _dbContext.Remove( entity );
            _dbContext.SaveChanges();
        }

        public IEnumerable<Clinic> GetAll()
        {
            return _dbContext.Set<Clinic>().ToList();
        }

        public Clinic GetById(int id)
        {
            return _dbContext.Clinics.SingleOrDefault(c => c.Id == id);
        }
    }
}
