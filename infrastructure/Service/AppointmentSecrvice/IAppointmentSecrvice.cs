using infrastructure.DTOs.AppointmentDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infrastructure.Service.AppointmentSecrvice
{
    public interface IAppointmentSecrvice
    {
        void Add(AppointmentDtoAdd appointmentDtoAdd);
        void Delete(int id);
        IEnumerable<AppointmentDtoGet> GetAll();
        AppointmentDtoGet GetById(int id);
    }
}
