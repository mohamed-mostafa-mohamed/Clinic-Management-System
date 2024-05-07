using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_DAL.Models
{
    public class Dignosis
    {
        [Key]
        public int ID { get; set; }
        public string Disease { get; set; }

    }
}
