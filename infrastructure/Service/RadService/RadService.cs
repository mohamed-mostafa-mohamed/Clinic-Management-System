using APP_DAL.Models;
using APP_DAL.Repo.RadRepo;
using infrastructure.DTOs.LabDtos;
using infrastructure.DTOs.RadDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infrastructure.Service.RadService
{
    public class RadService : IRadService
    {
        private readonly IRadRepo _radRepo;

        public RadService(IRadRepo radRepo)
        {
            _radRepo = radRepo;
        }
        public void Add(RadDtoAdd radDtoAdd)
        {
            var rad = new Radiology() 
            { 
                Name = radDtoAdd.Name,
                Price= radDtoAdd.Price,
            };
                _radRepo.Add(rad);
        }

        public void Delete(int id)
        {
            var rad = _radRepo.GetById(id);
            _radRepo.Delete(rad);
        }

        public IEnumerable<RadDtoGet> GetAll()
        {
            var rad = _radRepo.GetAll();
            return rad.Select(x => new RadDtoGet()
            {
                Name=x.Name,
                Id=x.Id,
                Price = x.Price,
               
            });
            
        }
        public RadDtoGet GetById(int id)
        {
            var rad =_radRepo.GetById(id);
            if (rad == null) return null;
            return new RadDtoGet() 
            {
                Name = rad.Name,
                Id = rad.Id,
                Price = rad.Price,
            };

        }
    }
}
