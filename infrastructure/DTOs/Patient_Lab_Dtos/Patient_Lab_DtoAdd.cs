﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infrastructure.DTOs.Patient_Lab_Dtos
{
    public class Patient_Lab_DtoAdd
    {
        public int PatientId { get; set; }
        public int LabId { get; set; }
        public DateTime Add_Time { get; set; }
        public int Add_By { get; set; }
    }
}
