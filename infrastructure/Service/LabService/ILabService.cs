using infrastructure.DTOs.DoctorDtos;
using infrastructure.DTOs.LabDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infrastructure.Service.LabService
{
    public interface ILabService 
    {
        IEnumerable<LabDtoGet> GetAll();
        LabDtoGet GetById(int id);
        void Add(LabDtoAdd entity);
        void Delete(LabDtoGet entity);
    }
}
