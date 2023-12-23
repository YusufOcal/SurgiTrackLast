using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApandisitController : ControllerBase
    {
        IApandisitService _apandisitService;

        public ApandisitController(IApandisitService apandisitService)
        {
            _apandisitService = apandisitService;
        }

        [HttpGet("GetAllApandisit")]
        public IActionResult GetAll()

        {
            var result = _apandisitService.GetAll();
            return Ok(result);
        }

        [HttpGet("GetByIdApandisit")]
        public IActionResult GetById(int id)

        {
            var result = _apandisitService.GetById(id);
            return Ok(result);
        }

        [HttpDelete("ApandisitDeleteById")]
        public IActionResult Delete(int id)

        {
            _apandisitService.DeleteById(id);
            return Ok();
        }

        [HttpDelete("ApandisitDelete")]
        public IActionResult Deleteaaa(Apandisit apandisit)

        {
            _apandisitService.Delete(apandisit);
            return Ok();
        }

        [HttpPost("ApandisitAdd")]
        public IActionResult Add(Apandisit apandisit)

        {
            _apandisitService.Add(apandisit);
            return Ok();
        }

        [HttpPut("ApandisitUpdate")]
        public IActionResult Update(Apandisit apandisit)

        {
            _apandisitService.Update(apandisit);
            return Ok();
        }
    }
}
