using APP_DAL.Models;
using AutoMapper;
using infrastructure.DTOs.PatientDtos;
using infrastructure.Service.PatientService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GP_CMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        private readonly IPatientService _patientService;
        public PatientController(IPatientService patientService)
        {
            _patientService = patientService;
        }
        [HttpGet]
        public ActionResult GetAll()
        {
            var pat = _patientService.GetAll();
            return Ok(pat);
        }
        [HttpGet("GetById")]
        public ActionResult GetById(int id)
        {
            var pat = _patientService.GetById(id);
            return Ok(pat);
        }
        [HttpPost]
        public void Add([FromForm]PatientDTOAdd patientDTOAdd)
        {
          _patientService.Add(patientDTOAdd);
        }
        [HttpDelete]
        public void Delete(PatientDTOGet patientDTOGet)
        {
            _patientService.Delete(patientDTOGet);
        }

    }
}
