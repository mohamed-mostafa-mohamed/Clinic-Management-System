using APP_DAL.Models;
using APP_DAL.Repo.Patient_Rad_Repo;
using infrastructure.DTOs.Patient_Lab_Dtos;
using infrastructure.DTOs.Patient_Rad_Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infrastructure.Service.Patient_Rad_Service
{
    public class Patient_Rad_Service : IPatient_Rad_Service
    {
        private readonly IPatient_Rad_Repo _patient_Rad_Repo;

        public Patient_Rad_Service(IPatient_Rad_Repo patient_Rad_Repo)
        {
            _patient_Rad_Repo = patient_Rad_Repo;
        }
        public void Add(Patient_Rad_DtoAdd patient_Rad_DtoAdd)
        {
            var pat = new PatientRadiology() 
            {
                Add_By= patient_Rad_DtoAdd.Add_By,
                Add_Time= patient_Rad_DtoAdd.Add_Time,
                PatientId= patient_Rad_DtoAdd.PatientId,
                RadiologyId= patient_Rad_DtoAdd.PatientId
            };
                _patient_Rad_Repo.Add(pat);
        }

        public void Delete(Patient_Rad_DtoGet patient_Rad_DtoGet)
        {
            var pat = new PatientRadiology()
            {

                Add_By = patient_Rad_DtoGet.Add_By,
                Add_Time = patient_Rad_DtoGet.Add_Time,

                PatientId = patient_Rad_DtoGet.PatientId,
                RadiologyId = patient_Rad_DtoGet.PatientId,
                Id = patient_Rad_DtoGet.Id
            };
            _patient_Rad_Repo.Delete(pat);
        }

        public IEnumerable<Patient_Rad_DtoGet> GetAll()
        {
            var pat = _patient_Rad_Repo.GetAll();
            return pat.Select(x=> new Patient_Rad_DtoGet() 
            {

                Add_By = x.Add_By,
                Add_Time = x.Add_Time,

                PatientId = x.PatientId,
                RadiologyId = x.PatientId,
                Id = x.Id
            }).ToList();
            
        }

        public Patient_Rad_DtoGet GetById(int id)
        {
            var pat =_patient_Rad_Repo.GetById(id);
            return new Patient_Rad_DtoGet() 
            {

                Add_By = pat.Add_By,
                Add_Time = pat.Add_Time,

                PatientId = pat.PatientId,
                RadiologyId = pat.PatientId,
                Id = pat.Id
            };
        }
    }
}
