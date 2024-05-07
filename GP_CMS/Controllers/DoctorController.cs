using infrastructure.DTOs.DoctorDtos;
using infrastructure.Service.DoctorService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GP_CMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        private readonly IDoctorService _doctorService;

        public DoctorController(IDoctorService doctorService)
        {
            _doctorService = doctorService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var doc = _doctorService.GetAll();
            return Ok(doc);
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var doc = _doctorService.GetById(id);
            return Ok(doc);
        }
        [HttpPost]
        public void Add(DoctorDTOsAdd doctorDTOs)
        {
            _doctorService.Add(doctorDTOs);
        }
        [HttpDelete]
        public void Delete(DoctorDTOsGet doctorDTOs)
        {
            _doctorService.Delete(doctorDTOs);
        }
    }
}
