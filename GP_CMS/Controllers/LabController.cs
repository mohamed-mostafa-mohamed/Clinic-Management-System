using infrastructure.DTOs.LabDtos;
using infrastructure.Service.LabService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GP_CMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LabController : ControllerBase
    {
        private readonly ILabService _labService;

        public LabController(ILabService labService)
        {
            _labService = labService;
        }
        [HttpGet]
        public ActionResult GetAll()
        {
            var lab = _labService.GetAll();
            return Ok(lab);
        }
        [HttpGet("GetById")]
        public ActionResult Get(int id)
        {
            var lab = _labService.GetById(id);
            return Ok(lab);
        }
        [HttpPost]
        public void AddLab(LabDtoAdd labDtoAdd)
        {
            _labService.Add(labDtoAdd);
        }

        [HttpDelete("id")]
        public void DeleteLab(LabDtoGet labDtoGet)
        {
            _labService.Delete(labDtoGet);
        }
    }
}
