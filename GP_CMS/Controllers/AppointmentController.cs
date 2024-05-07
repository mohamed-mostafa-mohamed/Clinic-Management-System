using infrastructure.DTOs.AppointmentDtos;
using infrastructure.Service.AppointmentSecrvice;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GP_CMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentController : ControllerBase
    {
        private readonly IAppointmentSecrvice _appointmentSecrvice;

        public AppointmentController(IAppointmentSecrvice appointmentSecrvice)
        {
            _appointmentSecrvice = appointmentSecrvice;
        }
        [HttpGet]
        public ActionResult GetAll()
        {
            var appo = _appointmentSecrvice.GetAll();
            return Ok(appo);
        }
        [HttpGet("GetById")]
        public ActionResult GetById(int id)
        {
            var appo = _appointmentSecrvice.GetById(id);
            return Ok(appo);
        }
        [HttpPost]
        public void Add(AppointmentDtoAdd appointmentDtoAdd)
        {
            _appointmentSecrvice.Add(appointmentDtoAdd);
        }
        [HttpDelete]
        public void Delete(int id)
        {
            _appointmentSecrvice.Delete(id);
        }
    }
}
