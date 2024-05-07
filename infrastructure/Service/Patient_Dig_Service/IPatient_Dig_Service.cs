using infrastructure.DTOs.Patient_Dig_Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infrastructure.Service.Patient_Dig_Service
{
    public interface IPatient_Dig_Service
    {
        void Add(Patient_Dig_DtoAdd patient_Dig_DtoAdd);
        void Delete(Patient_Dig_DtoGet patient_Dig_DtoGet);
        Patient_Dig_DtoGet GetById(int id);
        IEnumerable<Patient_Dig_DtoGet> GetAll();
    }
}
