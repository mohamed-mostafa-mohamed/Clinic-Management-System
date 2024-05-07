using infrastructure.DTOs.Billing_appo_Dtos;
using infrastructure.DTOs.Billing_Lab_Dtos;
using infrastructure.DTOs.Billing_Rad_Dtos;
using infrastructure.DTOs.Patient_Lab_Dtos;
using infrastructure.DTOs.Patient_Rad_Dtos;
using infrastructure.Service.Billing_Rad_Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GP_CMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Billing_RadController : ControllerBase
    {
        private readonly IBilling_Rad_Service _billing_Rad_Service;

        public Billing_RadController(IBilling_Rad_Service billing_Rad_Service)
        {
           _billing_Rad_Service = billing_Rad_Service;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var bill = _billing_Rad_Service.GetAll();
            return Ok(bill);
        }
        [HttpGet("GetById")]
        public IActionResult GetById(int id)
        {
            var bill = _billing_Rad_Service.Get(id);
            return Ok(bill);
        }
        [HttpPost]
        public void Add(Billing_Rad_DtoAdd billing_Rad_DtoAdd)
        {
            _billing_Rad_Service.add(billing_Rad_DtoAdd);
        }
        [HttpDelete]
        public void Delete(int id)
        {
            _billing_Rad_Service.Delete(id);
        }
        [HttpPost("makeRad")]
        public void MakeRad_billing(Patient_Rad_DtoAdd patient_Rad_DtoAdd, int amount)
        {
            _billing_Rad_Service.MakeRad_billing(patient_Rad_DtoAdd, amount);
        }
        [HttpPatch("updateBilling")]
        public ActionResult UpdateBilling(int patientId, int RabId, DateTime date)
        {
            _billing_Rad_Service.UpdateBilling(patientId, RabId, date);
            return Ok();
        }
        [HttpGet("GetBillingPayedOrPending")]
        public ActionResult<Billing_Rad_DtoGet> GetBillingPayedOrPending(int type)
        {
            var bill = _billing_Rad_Service.GetBillingPayedOrPending(type);
            if (bill == null)
            {
                return NoContent();
            }
            return Ok(bill);


        }
    }
}
