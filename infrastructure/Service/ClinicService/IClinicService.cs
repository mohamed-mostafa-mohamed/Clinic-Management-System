using APP_DAL.Models;
using APP_DAL.Repo.GenericRepo;
using infrastructure.DTOs.ClinicDtos;
using infrastructure.DTOs.DoctorDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infrastructure.Service.ClinicService
{
    public interface IClinicService
    {
        IEnumerable<ClinicDtoGet> GetAll();
        ClinicDtoGet GetById(int id);
        void Add(ClinicDtoAdd entity);
        void Delete(ClinicDtoGet entity);
    }
}
