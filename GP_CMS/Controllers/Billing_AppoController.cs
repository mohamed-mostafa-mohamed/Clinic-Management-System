using infrastructure.DTOs.AppointmentDtos;
using infrastructure.DTOs.Billing_appo_Dtos;
using infrastructure.Service.Billing_appo_Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GP_CMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Billing_AppoController : ControllerBase
    {
        private readonly IBilling_appo_Service _billing_Appo_Service;

        public Billing_AppoController(IBilling_appo_Service billing_Appo_Service)
        {
            _billing_Appo_Service = billing_Appo_Service;
        }
        [HttpGet]
        public ActionResult Get()
        {
            var bill = _billing_Appo_Service.GetAll();
            return Ok(bill);
        }
        [HttpGet("GetById")]
        public ActionResult GetById(int id)
        {
            var bill = _billing_Appo_Service.Get(id);
            return Ok(bill);
        }
        [HttpPost]
        public void Add(Billing_appo_DtosAdd appo_DtosAdd)
        {
            _billing_Appo_Service.add(appo_DtosAdd);
        }
        [HttpDelete]
        public void Delete(Billing_appo_DtosGet billing_Appo_DtosGet)
        {
            _billing_Appo_Service.Delete(billing_Appo_DtosGet);
        }
        [HttpPost("makeappointment")]
        public void MakeAppointment(AppointmentDtoAdd appointmentDtoAdd,  int amount)
        {
            _billing_Appo_Service.MakeAppointment_billing(appointmentDtoAdd,  amount);
        }
        [HttpPatch("updateBilling")]
        public void UpdateBilling(int doctorId, DateTime date, int patientId)
        {
            _billing_Appo_Service.UpdateBilling(patientId, doctorId, date);
        }
        [HttpGet("GetBillingPayedOrPending")]
        public ActionResult GetBillingPayedOrPending(int type)
        {
           var bill= _billing_Appo_Service.GetBillingPayedOrPending(type);
            if (bill == null)
            {
                return NoContent();
            }
            return Ok(bill);
        }
    }
}
