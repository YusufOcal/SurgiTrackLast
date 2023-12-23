using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AntiRefluController : ControllerBase
    {
        IAntiRefluService _antirefluService;

        public AntiRefluController(IAntiRefluService antirefluService)
        {
            _antirefluService = antirefluService;
        }

        [HttpGet("GetAllAntiReflu")]
        public IActionResult GetAll()

        {
            var result = _antirefluService.GetAll();
            return Ok(result);
        }

        [HttpGet("GetByIdAntiReflu")]
        public IActionResult GetById(int id)

        {
            var result = _antirefluService.GetById(id);
            return Ok(result);
        }

        [HttpDelete("AntiRefluDeleteById")]
        public IActionResult Delete(int id)

        {
            _antirefluService.DeleteById(id);
            return Ok();
        }

        [HttpDelete("AntiRefluDelete")]
        public IActionResult Deleteaaa(AntiReflu antireflu)

        {
            _antirefluService.Delete(antireflu);
            return Ok();
        }

        [HttpPost("AntiRefluAdd")]
        public IActionResult Add(AntiReflu antireflu)

        {
            _antirefluService.Add(antireflu);
            return Ok();
        }

        [HttpPut("AntiRefluUpdate")]
        public IActionResult Update(AntiReflu antireflu)

        {
            _antirefluService.Update(antireflu);
            return Ok();
        }
    }
}
