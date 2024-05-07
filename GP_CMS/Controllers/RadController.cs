using infrastructure.DTOs.RadDtos;
using infrastructure.Service.RadService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GP_CMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RadController : ControllerBase
    {
        private readonly IRadService _radService;

        public RadController(IRadService radService)
        {
            _radService = radService;
        }
        [HttpGet]
        public ActionResult GetAll() 
        {
            var rad=  _radService.GetAll();
            return Ok(rad);
        }
        [HttpGet("GetById")]
        public ActionResult GetById(int id) 
        {
            var red = _radService.GetById(id);
            return Ok(red);
        }
        [HttpPost]
        public void Add(RadDtoAdd radDtoAdd)
        { 
            _radService.Add(radDtoAdd);
        }
        [HttpDelete]
        public void Delete(int id)
        {
            _radService.Delete(id);
        }
    }
}
