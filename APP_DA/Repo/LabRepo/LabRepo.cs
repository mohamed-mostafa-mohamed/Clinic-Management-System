using APP_DAL.Context;
using APP_DAL.Models;
using APP_DAL.Repo.GenericRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_DAL.Repo.LabRepo
{
    public class LabRepo : IGeneric<Lab>, ILabRepo
    {
        private readonly ApplicationDbContext _dbContext;

        public LabRepo(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Add(Lab entity)
        {
            _dbContext.Add(entity);
            _dbContext.SaveChanges();
        }

        public void Delete(Lab entity)
        {
            _dbContext.Remove(entity);
            _dbContext.SaveChanges();
        }

        public IEnumerable<Lab> GetAll()
        {
            return _dbContext.Set<Lab>().ToList();
        }

        public Lab GetById(int id)
        {
           return _dbContext.Labs.SingleOrDefault(x=> x.Id == id);
        }
    }
}
