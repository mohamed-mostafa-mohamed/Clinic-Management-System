using infrastructure.DTOs.Patient_Lab_Dtos;
using infrastructure.DTOs.Patient_Rad_Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infrastructure.Service.Patient_Rad_Service
{
    public interface IPatient_Rad_Service
    {
        void Add(Patient_Rad_DtoAdd patient_Rad_DtoAdd);
        void Delete(Patient_Rad_DtoGet patient_Rad_DtoGet);
        Patient_Rad_DtoGet GetById(int id);
        IEnumerable<Patient_Rad_DtoGet> GetAll();
    }
}
