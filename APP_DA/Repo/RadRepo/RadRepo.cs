using APP_DAL.Context;
using APP_DAL.Models;
using APP_DAL.Repo.GenericRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_DAL.Repo.RadRepo
{
    public class RadRepo : IGeneric<Radiology>, IRadRepo
    {
        private readonly ApplicationDbContext _dbContext;

        public RadRepo(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Add(Radiology entity)
        {
            _dbContext.Add(entity);
            _dbContext.SaveChanges();
        }

        public void Delete(Radiology entity)
        {
            _dbContext.Remove(entity);
            _dbContext.SaveChanges();
        }

        public IEnumerable<Radiology> GetAll()
        {
           return _dbContext.Set<Radiology>().ToList();
        }

        public Radiology GetById(int id)
        {
            return _dbContext.Radiologies.SingleOrDefault(x => x.Id == id);
        }
    }
}
