using infrastructure.DTOs.PatientDtos;
using infrastructure.DTOs.RadDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infrastructure.Service.RadService
{
    public interface IRadService
    {
        void Add(RadDtoAdd radDtoAdd);
        void Delete(int id);
        IEnumerable<RadDtoGet> GetAll();
        RadDtoGet GetById(int id);
    }
}
