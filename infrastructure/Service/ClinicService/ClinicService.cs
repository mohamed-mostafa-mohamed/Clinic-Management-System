using APP_DAL.Models;
using APP_DAL.Repo.ClinicRepo;
using APP_DAL.Repo.GenericRepo;
using infrastructure.DTOs.ClinicDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infrastructure.Service.ClinicService
{
    public class ClinicService : IClinicService 
    {
        private readonly IClinicRepo _clinicRepo;

        public ClinicService(IClinicRepo clinicRepo)
        {
            _clinicRepo = clinicRepo;
        }

        public void Add(ClinicDtoAdd entity)
        {
            var clinic = new Clinic() { Name = entity.Name };
            _clinicRepo.Add(clinic);
            
        }

        public void Delete(ClinicDtoGet entity)
        {
            var clinic = new Clinic() 
            { Name = entity.Name,
                Id=entity.Id
            };
            _clinicRepo.Delete(clinic);
        }

        public IEnumerable<ClinicDtoGet> GetAll()
        {
            var clinic = _clinicRepo.GetAll();
            return clinic.Select(x => new ClinicDtoGet
            {
                Name = x.Name,
                Id = x.Id,
            }).ToList();
            
        }

        public ClinicDtoGet GetById(int id)
        {
            var clinic = _clinicRepo.GetById(id);
            if(clinic == null)return null;
            return new ClinicDtoGet() 
            { 
                Name = clinic.Name,
                Id = clinic.Id,
            };
        }
    }
}
