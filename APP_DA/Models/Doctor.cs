using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_DAL.Models
{
    public class Doctor
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Specialty { get; set; }
        public int Salary { get; set; }
        public int Phone { get; set; }
        public string Degree { get; set; }
        public int ClinicId { get; set; }
        public Clinic Clinic { get; set; }
    }
}
