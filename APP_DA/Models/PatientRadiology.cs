using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_DAL.Models
{
    public class PatientRadiology
    {
        [Key]
        public int Id { get; set; }
        public int PatientId { get; set; }
        public Patient Patient { get; set; }
        public int RadiologyId { get; set; }
        public Radiology Radiology { get; set; }
        public DateTime Add_Time { get; set; }
        public int Add_By { get; set; }
    }
}
