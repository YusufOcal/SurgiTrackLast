using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnalAtreziController : ControllerBase
    {
        IAnalAtreziService _analatreziService;

        public AnalAtreziController(IAnalAtreziService analatreziService)
        {
            _analatreziService = analatreziService;
        }

        [HttpGet("GetAllAnalAtrezi")]
        public IActionResult GetAll()

        {
            var result = _analatreziService.GetAll();
            return Ok(result);
        }

        [HttpGet("GetByIdAnalAtrezi")]
        public IActionResult GetById(int id)

        {
            var result = _analatreziService.GetById(id);
            return Ok(result);
        }

        [HttpDelete("AnalAtreziDeleteById")]
        public IActionResult Delete(int id)

        {
            _analatreziService.DeleteById(id);
            return Ok();
        }

        [HttpDelete("AnalAtreziDelete")]
        public IActionResult Deleteaaa(AnalAtrezi analatrezi)

        {
            _analatreziService.Delete(analatrezi);
            return Ok();
        }

        [HttpPost("AnalAtreziAdd")]
        public IActionResult Add(AnalAtrezi analatrezi)

        {
            _analatreziService.Add(analatrezi);
            return Ok();
        }

        [HttpPut("AnalAtreziUpdate")]
        public IActionResult Update(AnalAtrezi analatrezi)

        {
            _analatreziService.Update(analatrezi);
            return Ok();
        }
    }
}
