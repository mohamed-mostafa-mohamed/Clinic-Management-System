using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infrastructure.DTOs.Billing_Rad_Dtos
{
    public class Billing_Rad_DtoAdd
    {
        public int Amount { get; set; }
        public int Type { get; set; }
        public DateTime Date_Time { get; set; }

        public int RadiologyId { get; set; }


        public int PatientId { get; set; }
    }
}
