
using infrastructure.DTOs.Patient_Lab_Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infrastructure.Service.Patient_Lab_Service
{
    public interface IPatient_Lab_Service
    {
        void Add(Patient_Lab_DtoAdd patient_Lab_DtoAdd);
        void Delete(int id);
        Patient_Lab_DtoGet GetById(int id);
        IEnumerable<Patient_Lab_DtoGet> GetAll();
    }
}
