using APP_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infrastructure.DTOs.AppointmentDtos
{
    public class AppointmentDtoAdd
    {

        public DateTime Date_time { get; set; }
        public int Status { get; set; }
        public int Add_By { get; set; }
        public int DoctorId { get; set; }
        public int PatientId { get; set; }
        public int ClinicId { get; set; }

    }
}
