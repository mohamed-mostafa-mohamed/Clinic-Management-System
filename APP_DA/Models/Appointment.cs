using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_DAL.Models
{
    public class Appointment
    {
        [Key]
        public int Id { get; set; }
        public DateTime Date_time { get; set; }
        public int Status { get; set; }
        public int Add_By { get; set; }
        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; }

        public int PatientId { get; set; }
        public Patient Patient { get; set; }

        public int ClinicId { get; set; }
        public Clinic Clinic { get; set; }

    }
}
