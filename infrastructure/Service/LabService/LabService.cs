using APP_DAL.Models;
using APP_DAL.Repo.GenericRepo;
using APP_DAL.Repo.LabRepo;
using infrastructure.DTOs.LabDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infrastructure.Service.LabService
{
    public class LabService : ILabService
    {
        private readonly ILabRepo _labRepo;

        public LabService(ILabRepo labRepo)
        {
            _labRepo = labRepo;
        }

        public void Add(LabDtoAdd entity)
        {
            var lab = new Lab()
            {
                Name= entity.Name,
                Price=entity.Price,
            };
            _labRepo.Add(lab);
        }

        public void Delete(LabDtoGet entity)
        {
            var lab = new Lab()
            {
                Name = entity.Name,
                Id = entity.Id,
                Price = entity.Price,
            };
            _labRepo.Delete(lab);
        }

        public IEnumerable<LabDtoGet> GetAll()
        {
            var lab = _labRepo.GetAll();
            return lab.Select(x => new LabDtoGet 
            {
                Id=x.Id,
                Name=x.Name,
                Price=x.Price
            });   
        }

        public LabDtoGet GetById(int id)
        {
            var lab = _labRepo.GetById(id);
            if (lab == null)return null;
            return new LabDtoGet
            {
                Id = lab.Id,
                Name = lab.Name
            };
        }
    }
}
