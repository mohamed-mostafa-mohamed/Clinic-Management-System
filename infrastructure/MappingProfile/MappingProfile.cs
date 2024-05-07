using APP_DAL.Models;
using AutoMapper;
using infrastructure.DTOs.AppointmentDtos;
using infrastructure.DTOs.PatientDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infrastructure.MappingProfile
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //PatientMap
            CreateMap<Patient, PatientDTOGet>();
            CreateMap<Patient, PatientDTOAdd>()
                .ReverseMap();
            //AppoimentMap
            CreateMap<Appointment,AppointmentDtoAdd>();
            CreateMap<Appointment, AppointmentDtoGet>()
                .ForMember(dest => dest.PatientId, ser => ser.MapFrom(ser => ser.Patient.Name))
                .ForMember(y => y.DoctorId, x => x.MapFrom(x => x.Doctor.Name))
                .ReverseMap();
        }
    }
}
