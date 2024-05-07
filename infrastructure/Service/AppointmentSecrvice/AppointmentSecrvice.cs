using APP_DAL.Models;
using APP_DAL.Repo.AppointmentRepo;
using AutoMapper;
using infrastructure.DTOs.AppointmentDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infrastructure.Service.AppointmentSecrvice
{
    public class AppointmentSecrvice : IAppointmentSecrvice
    {
        private readonly IAppointmentRepo _appointmentRepo;
        private readonly IMapper _mapper;

        public AppointmentSecrvice(IAppointmentRepo appointmentRepo,IMapper mapper)
        {
            _appointmentRepo = appointmentRepo;
            _mapper = mapper;
        }
        public void Add(AppointmentDtoAdd appointmentDtoAdd)
        {
            // var appo = _mapper.Map<Appointment>(appointmentDtoAdd);
            var appo = new Appointment
            {
                Date_time = appointmentDtoAdd.Date_time,
                Status = appointmentDtoAdd.Status,
                Add_By = appointmentDtoAdd.Add_By,
                DoctorId = appointmentDtoAdd.DoctorId,
                PatientId = appointmentDtoAdd.PatientId,
                ClinicId = appointmentDtoAdd.ClinicId
            };
            _appointmentRepo.Add(appo);
        }

        public void Delete(int id)
        {
            var appo = _appointmentRepo.GetById(id);
            _appointmentRepo.Delete(appo);
        }

        public IEnumerable<AppointmentDtoGet> GetAll()
        {
            var appo = _appointmentRepo.GetAll();
            return _mapper.Map<IEnumerable<AppointmentDtoGet>>(appo);
        }

        public AppointmentDtoGet GetById(int id)
        {
            var appo = _appointmentRepo.GetById(id);
            if (appo == null)return null;
            return _mapper.Map<AppointmentDtoGet>(appo);
        }

    }
}
