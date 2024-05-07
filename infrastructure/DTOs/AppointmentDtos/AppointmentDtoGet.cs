using APP_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infrastructure.DTOs.AppointmentDtos
{
    public class AppointmentDtoGet
    {
        public int Id { get; set; }
        public DateTime Date_time { get; set; }
        public int Status { get; set; }
        public int Add_By { get; set; }
        public string DoctorId { get; set; }

        public string PatientId { get; set; }

        public int ClinicId { get; set; }

    }
}
