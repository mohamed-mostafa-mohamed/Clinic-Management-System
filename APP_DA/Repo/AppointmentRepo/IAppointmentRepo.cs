using APP_DAL.Models;
using APP_DAL.Repo.GenericRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_DAL.Repo.AppointmentRepo
{
    public interface IAppointmentRepo : IGeneric<Appointment>
    {
        Task MakeAppo_Billing(Appointment appointment);
    }
}
