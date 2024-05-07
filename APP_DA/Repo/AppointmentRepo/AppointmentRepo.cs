using APP_DAL.Context;
using APP_DAL.Models;
using APP_DAL.Repo.GenericRepo;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_DAL.Repo.AppointmentRepo
{
    public class AppointmentRepo : IGeneric<Appointment>, IAppointmentRepo
    {
        private readonly ApplicationDbContext _dbContext;

        public AppointmentRepo(ApplicationDbContext dbContext)
        {
           _dbContext = dbContext;
        }
        public void Add(Appointment entity)
        {
            _dbContext.Add(entity);
            _dbContext.SaveChanges();
        }

        public void Delete(Appointment entity)
        {
            _dbContext.Appointments.Remove(entity);
            _dbContext.SaveChanges();
        }

        public IEnumerable<Appointment> GetAll()
        {
            return _dbContext.Set<Appointment>().Include(propa => propa.Patient).Include(propa => propa.Doctor).ToList();
        }

        public Appointment GetById(int id)
        {
            return _dbContext.Appointments.Include(propa => propa.Patient).Include(propa => propa.Doctor).SingleOrDefault(x => x.Id == id);
        }

        public async Task MakeAppo_Billing(Appointment appointment)
        {
            var pat = await _dbContext.AddAsync(appointment);
            await _dbContext.SaveChangesAsync();
        }
    }
}
