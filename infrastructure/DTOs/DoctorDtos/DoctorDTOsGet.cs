﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infrastructure.DTOs.DoctorDtos
{
    public class DoctorDTOsGet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Specialty { get; set; }
        public int Salary { get; set; }
        public int Phone { get; set; }
        public string Degree { get; set; }
    }
}
