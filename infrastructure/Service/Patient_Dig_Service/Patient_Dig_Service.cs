using APP_DAL.Models;
using APP_DAL.Repo.Patient_Dig_Repo;
using infrastructure.DTOs.Patient_Dig_Dtos;
using infrastructure.Service.PatientService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infrastructure.Service.Patient_Dig_Service
{
    public class Patient_Dig_Service : IPatient_Dig_Service
    {
        private readonly IPatient_Dig_Repo _patient_Dig_Repo;

        public Patient_Dig_Service(IPatient_Dig_Repo patient_Dig_Repo)
        {
            _patient_Dig_Repo = patient_Dig_Repo;
        }
        public void Add(Patient_Dig_DtoAdd patient_Dig_DtoAdd)
        {
            var app = new PatientDignosis()
            {
                DignosisId= patient_Dig_DtoAdd.DignosisId,
                DoctorId= patient_Dig_DtoAdd.DoctorId,
                PatientId= patient_Dig_DtoAdd.PatientId
            };
            _patient_Dig_Repo.Add(app);
        }

        public void Delete(Patient_Dig_DtoGet patient_Dig_DtoGet)
        {
            var dig = new PatientDignosis()
            {
                DignosisId = patient_Dig_DtoGet.DignosisId,
                DoctorId = patient_Dig_DtoGet.DoctorId,
                PatientId = patient_Dig_DtoGet.PatientId,
                Id= patient_Dig_DtoGet.Id
            };
            _patient_Dig_Repo.Delete(dig);
        }

        public IEnumerable<Patient_Dig_DtoGet> GetAll()
        {
            var dig = _patient_Dig_Repo.GetAll();
            return dig.Select(x => new Patient_Dig_DtoGet()
            {
                DoctorId = x.DoctorId,
                DignosisId= x.DoctorId,
                PatientId = x.PatientId,
                Id = x.Id
            }
            ).ToList();
        }

        public Patient_Dig_DtoGet GetById(int id)
        {
            var dig = _patient_Dig_Repo.GetById(id);
            if (dig == null) return null;
            return new Patient_Dig_DtoGet()
            {
                DignosisId= dig.DoctorId,
                DoctorId= dig.DoctorId,
                PatientId= dig.PatientId,
                Id = dig.Id
            };
        }
    }
}
