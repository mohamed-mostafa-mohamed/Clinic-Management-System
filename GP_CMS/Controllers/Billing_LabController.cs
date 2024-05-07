using infrastructure.DTOs.AppointmentDtos;
using infrastructure.DTOs.Billing_appo_Dtos;
using infrastructure.DTOs.Billing_Lab_Dtos;
using infrastructure.DTOs.Patient_Lab_Dtos;
using infrastructure.Service.Billing_appo_Service;
using infrastructure.Service.Billing_Lab_Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GP_CMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Billing_LabController : ControllerBase
    {
        
        private readonly IBilling_Lab_Service _billing_Lab_Service;

        public Billing_LabController(IBilling_Lab_Service billing_Lab_Service)
        {
            _billing_Lab_Service = billing_Lab_Service;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var bill = _billing_Lab_Service.GetAll();
            return Ok(bill);
        }
        [HttpGet("GetById")]
        public IActionResult GetById(int id)
        {
            var bill = _billing_Lab_Service.Get(id);
            return Ok(bill);    
        }
        [HttpPost]
        public void Add(Billing_Lab_Dto_Add billing_Lab_Dto_Add)
        {
            _billing_Lab_Service.add(billing_Lab_Dto_Add);
        }
        [HttpDelete]
        public void Delete(Billing_Lab_DTO_Get billing_Lab_DTO_Get)
        {
            _billing_Lab_Service.Delete(billing_Lab_DTO_Get);
        }
        [HttpPost("makeLab")]
        public void MakeLab_billing(Patient_Lab_DtoAdd patient_Lab_DtoAdd, int amount)
        {
            _billing_Lab_Service.MakeLab_billing(patient_Lab_DtoAdd, amount);
        }
        [HttpPatch("updateBilling")]
        public ActionResult UpdateBilling(int patientId, int labId, DateTime date)
        {
            _billing_Lab_Service.UpdateBilling(patientId, labId, date);
            return Ok();
        }
        [HttpGet("GetBillingPayedOrPending")]
        public ActionResult<Billing_Lab_DTO_Get> GetBillingPayedOrPending(int type)
        {
            var bill = _billing_Lab_Service.GetBillingPayedOrPending(type);
            if (bill == null)
            {
                return NoContent();
            }
            return Ok(bill);


        }

    }
}
