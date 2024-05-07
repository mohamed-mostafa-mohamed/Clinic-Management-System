using APP_DAL.Models;
using APP_DAL.Repo.GenericRepo;
using APP_DAL.Repo.PatientRepo;
using AutoMapper;
using infrastructure.DTOs.DoctorDtos;
using infrastructure.DTOs.PatientDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infrastructure.Service.PatientService
{
    public class PatientService : IPatientService
    {
        private readonly IPatientRepo _patientRepo;
        private readonly IMapper _mapper;

        public PatientService(IPatientRepo patientRepo,IMapper mapper)
        {
            _patientRepo = patientRepo;
            _mapper = mapper;
        }
        public void Add(PatientDTOAdd entity)
        {
            var pat = _mapper.Map<Patient>(entity);
            _patientRepo.Add(pat);
        }

        public void Delete(PatientDTOGet patientDTOGet)
        {
            var pat =_mapper.Map<Patient>(patientDTOGet);
            _patientRepo.Delete(pat);
        }

        public IEnumerable<PatientDTOGet> GetAll()
        {
            var pat = _patientRepo.GetAll();
            return _mapper.Map<IEnumerable<PatientDTOGet>>(pat);
        }

        public PatientDTOGet GetById(int id)
        {
            var pat = _patientRepo.GetById(id);
            if (pat == null)return null;
            return _mapper.Map<PatientDTOGet>(pat);
        }
    }
}
