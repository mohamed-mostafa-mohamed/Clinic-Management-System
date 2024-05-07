using APP_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infrastructure.DTOs.Billing_Lab_Dtos
{
    public class Billing_Lab_DTO_Get
    {
        public int Id { get; set; }
        public int Amount { get; set; }
        public int Type { get; set; }
        public DateTime Date_Time { get; set; }
        public int LabId { get; set; }
        public int PatientId { get; set; }
    }
}
