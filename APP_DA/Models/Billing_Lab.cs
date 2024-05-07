﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_DAL.Models
{
    public class Billing_Lab
    {
        [Key]
        public int Id { get; set; }
        public int Amount { get; set; }
        public int Type { get; set; }
        public DateTime Date_Time { get; set; }

        public int LabId { get; set; }
        public Lab Lab { get; set; }

        //public int PatientId { get; set; }
        //public Patient Patient { get; set; }
    }
}
