using APP_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infrastructure.DTOs.Patient_Dig_Dtos
{
    public class Patient_Dig_DtoGet
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        public int DoctorId { get; set; }
        public int DignosisId { get; set; }

    }
}
