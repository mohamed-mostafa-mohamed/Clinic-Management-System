using APP_DAL.Models;
using infrastructure.DTOs.DoctorDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infrastructure.Service.DoctorService
{
    public interface IDoctorService 
    {
        IEnumerable<DoctorDTOsGet> GetAll();
        DoctorDTOsGet GetById(int id);
        void Add(DoctorDTOsAdd entity);
        void Delete(DoctorDTOsGet entity);
    }
}
