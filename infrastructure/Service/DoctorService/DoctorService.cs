using APP_DAL.Models;
using APP_DAL.Repo.DoctorRepo;
using AutoMapper;
using infrastructure.DTOs.DoctorDtos;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infrastructure.Service.DoctorService
{
    public class DoctorService :  IDoctorService
    {
        private readonly IDoctorRepository _doctorRepository;
        private readonly IMapper _mapper;

        public DoctorService(IDoctorRepository IDoctorRepository,IMapper mapper) 
        {
            _doctorRepository = IDoctorRepository;
            _mapper = mapper;
        }

        

        public void Add(DoctorDTOsAdd entity)
        {
            var doc  = new Doctor
                {
                    Name = entity.Name,
                    Salary = entity.Salary,
                    Specialty = entity.Specialty,
                    Phone = entity.Phone,
                    Degree = entity.Degree,
                    ClinicId = entity.ClinicId,
                };
            _doctorRepository.Add(doc);
        }

        public void Delete(DoctorDTOsGet entity)
        {
            var doc = new Doctor
            {
                Id = entity.Id,
                Name = entity.Name,
                Salary = entity.Salary,
                Specialty = entity.Specialty,
                Phone = entity.Phone,
                Degree = entity.Degree,
            };
            _doctorRepository.Delete(doc);


        }

        public IEnumerable<DoctorDTOsGet> GetAll()
        {
            var docDB = _doctorRepository.GetAll();
            return docDB.Select(x => new DoctorDTOsGet()
            {
                Salary=x.Salary,
                Specialty=x.Specialty,
                Phone=x.Phone,
                Degree=x.Degree,
                Id=x.Id,
                Name=x.Name,
            }).ToList();
        }

        public DoctorDTOsGet GetById(int id)
        {
            var doc = _doctorRepository.GetById(id);
            if (doc == null) return null;
            //var docdto = _mapper.Map<DoctorDTOsGet>(doc);
            //return docdto;
            return new DoctorDTOsGet()
            {
                Salary = doc.Salary,
                Specialty = doc.Specialty,
                Phone = doc.Phone,
                Degree = doc.Degree,
                Id = doc.Id,
                Name = doc.Name,
            };
        }
    }
}
