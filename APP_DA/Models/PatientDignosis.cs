using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_DAL.Models
{
    public class PatientDignosis
    {
        [Key]
        public int Id { get; set; }

        public int PatientId { get; set; }
        public Patient Patient { get; set; }


        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; }

        public int DignosisId { get; set; }
        public Dignosis Dignosis { get; set; }

    }
}
