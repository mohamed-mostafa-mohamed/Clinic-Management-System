using infrastructure.DTOs.ClinicDtos;
using infrastructure.Service.ClinicService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GP_CMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClinicController : ControllerBase
    {
        private readonly IClinicService _clinicService;

        public ClinicController(IClinicService clinicService)
        {
           _clinicService = clinicService;
        }
        [HttpGet]
        public ActionResult GetAll()
        {
           var clinic= _clinicService.GetAll().ToList();
            return Ok(clinic);

        }
        [HttpGet("GetById")]
        public ActionResult Get(int id)
        {
            var clinic = _clinicService.GetById(id);
            return Ok(clinic);
        }
        [HttpPost]
        public void Add(ClinicDtoAdd clinicDtoAdd) 
        {
            _clinicService.Add(clinicDtoAdd);
        }
        [HttpDelete]
        public void Delete(ClinicDtoGet clinicDtoGet) 
        {
            _clinicService.Delete(clinicDtoGet);
        }

    }
}
