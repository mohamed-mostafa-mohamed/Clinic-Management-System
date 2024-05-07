using infrastructure.DTOs.Billing_appo_Dtos;
using infrastructure.DTOs.Patient_Lab_Dtos;
using infrastructure.Service.Patient_Lab_Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GP_CMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Patient_LabController : ControllerBase
    {
        private readonly IPatient_Lab_Service _patient_Lab_Service;

        public Patient_LabController(IPatient_Lab_Service patient_Lab_Service)
        {
            _patient_Lab_Service = patient_Lab_Service;
        }
        [HttpGet]
        public ActionResult Get()
        {
            var bill = _patient_Lab_Service.GetAll();
            return Ok(bill);
        }
        [HttpGet("GetById")]
        public ActionResult GetById(int id)
        {
            var bill = _patient_Lab_Service.GetById(id);
            return Ok(bill);
        }
        [HttpPost]
        public void Add(Patient_Lab_DtoAdd patient_Lab_DtoAdd)
        {
            _patient_Lab_Service.Add(patient_Lab_DtoAdd);
        }
        [HttpDelete]
        public void Delete(int id)
        {
            _patient_Lab_Service.Delete(id);
        }
    }
}
