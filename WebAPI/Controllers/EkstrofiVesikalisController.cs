using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EkstrofiVesikalisController : ControllerBase
    {
        IEkstrofiVesikalisService _ekstrofivesikalisService;

        public EkstrofiVesikalisController(IEkstrofiVesikalisService ekstrofivesikalisService)
        {
            _ekstrofivesikalisService = ekstrofivesikalisService;
        }

        [HttpGet("GetAllEkstrofiVesikalis")]
        public IActionResult GetAll()

        {
            var result = _ekstrofivesikalisService.GetAll();
            return Ok(result);
        }

        [HttpGet("GetByIdEkstrofiVesikalis")]
        public IActionResult GetById(int id)

        {
            var result = _ekstrofivesikalisService.GetById(id);
            return Ok(result);
        }

        [HttpDelete("EkstrofiVesikalisDeleteById")]
        public IActionResult Delete(int id)

        {
            _ekstrofivesikalisService.DeleteById(id);
            return Ok();
        }

        [HttpDelete("EkstrofiVesikalisDelete")]
        public IActionResult Deleteaaa(EkstrofiVesikalis ekstrofivesikalis)

        {
            _ekstrofivesikalisService.Delete(ekstrofivesikalis);
            return Ok();
        }

        [HttpPost("EkstrofiVesikalisAdd")]
        public IActionResult Add(EkstrofiVesikalis ekstrofivesikalis)

        {
            _ekstrofivesikalisService.Add(ekstrofivesikalis);
            return Ok();
        }

        [HttpPut("EkstrofiVesikalisUpdate")]
        public IActionResult Update(EkstrofiVesikalis ekstrofivesikalis)

        {
            _ekstrofivesikalisService.Update(ekstrofivesikalis);
            return Ok();
        }
    }
}
