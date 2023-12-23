using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AmeliyatController : ControllerBase
    {
        IAmeliyatService _ameliyatService;

        public AmeliyatController(IAmeliyatService ameliyatService)
        {
            _ameliyatService = ameliyatService;
        }

        [HttpGet("GetAllAmeliyat")]
        public IActionResult GetAll()

        {
            var result = _ameliyatService.GetAll();
            return Ok(result);
        }

        [HttpGet("GetByIdAmeliyat")]
        public IActionResult GetById(int id)

        {
            var result = _ameliyatService.GetById(id);
            return Ok(result);
        }

        [HttpDelete("AmeliyatDeleteById")]
        public IActionResult Delete(int id)

        {
            _ameliyatService.DeleteById(id);
            return Ok();
        }

        [HttpDelete("AmeliyatDelete")]
        public IActionResult Deleteaaa(Ameliyat ameliyat)

        {
            _ameliyatService.Delete(ameliyat);
            return Ok();
        }

        [HttpPost("AmeliyatAdd")]
        public IActionResult Add(Ameliyat ameliyat)

        {
            _ameliyatService.Add(ameliyat);
            return Ok();
        }

        [HttpPut("AmeliyatUpdate")]
        public IActionResult Update(Ameliyat ameliyat)

        {
            _ameliyatService.Update(ameliyat);
            return Ok();
        }
    }
}
