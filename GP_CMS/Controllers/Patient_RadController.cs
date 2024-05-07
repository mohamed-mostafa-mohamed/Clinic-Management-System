using infrastructure.DTOs.Billing_appo_Dtos;
using infrastructure.DTOs.Patient_Rad_Dtos;
using infrastructure.Service.Patient_Rad_Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GP_CMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Patient_RadController : ControllerBase
    {
        private readonly IPatient_Rad_Service _patient_Rad_Service;

        public Patient_RadController(IPatient_Rad_Service patient_Rad_Service)
        {
            _patient_Rad_Service = patient_Rad_Service;
        }
        [HttpGet]
        public ActionResult Get()
        {
            var bill = _patient_Rad_Service.GetAll();
            return Ok(bill);
        }
        [HttpGet("GetById")]
        public ActionResult GetById(int id)
        {
            var bill = _patient_Rad_Service.GetById(id);
            return Ok(bill);
        }
        [HttpPost]
        public void Add(Patient_Rad_DtoAdd patient_Rad_DtoAdd)
        {
            _patient_Rad_Service.Add(patient_Rad_DtoAdd);
        }
        [HttpDelete]
        public void Delete(Patient_Rad_DtoGet patient_Rad_DtoGet)
        {
            _patient_Rad_Service.Delete(patient_Rad_DtoGet);
        }
    }
}
