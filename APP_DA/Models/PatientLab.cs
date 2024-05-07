using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_DAL.Models
{
    public class PatientLab
    {
        [Key]
        public int Id { get; set; }
        public int PatientId { get; set; }
        public Patient Patient { get; set; }
        public int LabId { get; set; }
        public Lab Lab { get; set; }
        public DateTime Add_Time { get; set; }
        public int Add_By { get; set;}
    }
}
