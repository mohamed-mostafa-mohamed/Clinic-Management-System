using APP_DAL.Context;
using APP_DAL.Models;
using APP_DAL.Repo.GenericRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_DAL.Repo.DignosisRepo
{
    public class DignosisRepo : IDignosisRepo, IGeneric<Dignosis>
    {
        private readonly ApplicationDbContext _dbContext;

        public DignosisRepo(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Add(Dignosis entity)
        {
            _dbContext.Add(entity);
            _dbContext.SaveChanges();
        }

        public void Delete(Dignosis entity)
        {
            _dbContext.Dignoses.Remove(entity);
            _dbContext.SaveChanges();
        }

        public IEnumerable<Dignosis> GetAll()
        {
            return _dbContext.Set<Dignosis>().ToList();
        }

        public Dignosis GetById(int id)
        {
            return _dbContext.Dignoses.SingleOrDefault(x=>x.ID == id);
        }
    }
}
