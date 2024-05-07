using infrastructure.DTOs.DignosisDtos;
using infrastructure.Service.DignosisService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GP_CMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DignosisController : ControllerBase
    {
        private readonly IDignosisService _dignosisService;

        public DignosisController(IDignosisService dignosisService)
        {
            _dignosisService = dignosisService;
        }
        [HttpGet]
        public ActionResult GetAll() 
        {
            var dig =_dignosisService.GetAll();
            return Ok(dig);
        }
        [HttpGet("GetById")]
        public ActionResult GetById(int id) 
        {
            var dig = _dignosisService.GetById(id);
            return Ok(dig);
        }
        [HttpPost]
        public void Add(DignosisDtoAdd dignosisDtoAdd) 
        {
            _dignosisService.Add(dignosisDtoAdd);
        }
        [HttpDelete]
        public void Delete(DignosisDtoGet dignosisDtoGet) 
        {
            _dignosisService.Delete(dignosisDtoGet);
        }

    }
}
