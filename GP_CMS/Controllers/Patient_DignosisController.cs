using infrastructure.DTOs.DignosisDtos;
using infrastructure.DTOs.Patient_Dig_Dtos;
using infrastructure.Service.Patient_Dig_Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GP_CMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Patient_DignosisController : ControllerBase
    {
        private readonly IPatient_Dig_Service _patient_Dig_Service;

        public Patient_DignosisController(IPatient_Dig_Service patient_Dig_Service)
        {
            _patient_Dig_Service = patient_Dig_Service;
        }
        [HttpGet]
        public ActionResult GetAll()
        {
            var dig = _patient_Dig_Service.GetAll();
            return Ok(dig);
        }
        [HttpGet("GetById")]
        public ActionResult GetById(int id)
        {
            var dig = _patient_Dig_Service.GetById(id);
            return Ok(dig);
        }
        [HttpPost]
        public void Add(Patient_Dig_DtoAdd patient_Dig_DtoAdd )
        {
            _patient_Dig_Service.Add(patient_Dig_DtoAdd);
        }
        [HttpDelete]
        public void Delete(Patient_Dig_DtoGet patient_Dig_DtoGet)
        {
            _patient_Dig_Service.Delete(patient_Dig_DtoGet);
        }
    }
}
