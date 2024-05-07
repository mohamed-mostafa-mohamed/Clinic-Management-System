using APP_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infrastructure.DTOs.Patient_Rad_Dtos
{
    public class Patient_Rad_DtoGet
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        public int RadiologyId { get; set; }
        public DateTime Add_Time { get; set; }
        public int Add_By { get; set; }
    }
}
