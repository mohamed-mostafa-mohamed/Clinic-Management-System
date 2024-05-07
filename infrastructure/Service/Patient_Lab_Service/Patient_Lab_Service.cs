using APP_DAL.Models;
using APP_DAL.Repo.Patient_Lab_Repo;
using infrastructure.DTOs.Patient_Dig_Dtos;
using infrastructure.DTOs.Patient_Lab_Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infrastructure.Service.Patient_Lab_Service
{
    public class Patient_Lab_Service : IPatient_Lab_Service
    {
        private readonly IPatient_Lab_Repo _patient_Lab_Repo;

        public Patient_Lab_Service(IPatient_Lab_Repo patient_Lab_Repo)
        {
            _patient_Lab_Repo = patient_Lab_Repo;
        }
        public void Add(Patient_Lab_DtoAdd patient_Lab_DtoAdd)
        {
            var pat = new PatientLab()
            {

                Add_By= patient_Lab_DtoAdd.Add_By,
                Add_Time= patient_Lab_DtoAdd.Add_Time,
                LabId= patient_Lab_DtoAdd.LabId,
                PatientId= patient_Lab_DtoAdd.PatientId,
                
            };
            _patient_Lab_Repo.Add(pat);
        }

        public void Delete(int id)
        {
            var pat = _patient_Lab_Repo.GetById(id);
            _patient_Lab_Repo.Add(pat);
        }

        public IEnumerable<Patient_Lab_DtoGet> GetAll()
        {
            var pat = _patient_Lab_Repo.GetAll();
            return pat.Select(x => new Patient_Lab_DtoGet()
            {

                Add_By = x.Add_By,
                Add_Time = x.Add_Time,
                LabId = x.LabId,
                PatientId = x.PatientId,
                Id = x.Id
            }
            ).ToList();
        }
        public Patient_Lab_DtoGet GetById(int id)
        {
            var pat = _patient_Lab_Repo.GetById(id);
            if (pat == null) return null;
            return new Patient_Lab_DtoGet()
            {
                Add_By = pat.Add_By,
                Add_Time = pat.Add_Time,
                LabId = pat.LabId,
                PatientId = pat.PatientId,
                Id = pat.Id
            };
        }
    }
}
