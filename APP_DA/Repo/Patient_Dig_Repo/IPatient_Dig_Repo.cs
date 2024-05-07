using APP_DAL.Models;
using APP_DAL.Repo.GenericRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_DAL.Repo.Patient_Dig_Repo
{
    public interface IPatient_Dig_Repo:IGeneric<PatientDignosis>
    {
    }
}
