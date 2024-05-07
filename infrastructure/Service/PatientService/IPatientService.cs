using APP_DAL.Repo.GenericRepo;
using infrastructure.DTOs.DoctorDtos;
using infrastructure.DTOs.PatientDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infrastructure.Service.PatientService
{
    public interface IPatientService 
    {
        IEnumerable<PatientDTOGet> GetAll();
        PatientDTOGet GetById(int id);
        void Add(PatientDTOAdd entity);
        void Delete(PatientDTOGet entity);
    }
}
