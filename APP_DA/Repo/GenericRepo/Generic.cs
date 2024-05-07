using APP_DAL.Context;
using APP_DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_DAL.Repo.GenericRepo
{
    public class Generic<T> : IGeneric<T> where T : class
    {
        public readonly ApplicationDbContext _DbContext;
        public Generic(ApplicationDbContext dbContext)
        {
            _DbContext = dbContext;
        }
        public IEnumerable<T> GetAll()
        {
            return _DbContext.Set<T>().ToList();
        }
        public T GetById(int id)
        {
            return _DbContext.Set<T>().Find(id);
        }

        public void Add(T entity)
        {
           _DbContext.Add(entity);
           _DbContext.SaveChanges();
        }

        public void Delete(T entity)
        {
            _DbContext.Remove(entity);
            _DbContext.SaveChanges();
        }
    }
}
