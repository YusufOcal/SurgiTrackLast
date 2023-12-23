using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoktorController : ControllerBase
    {
        IDoktorService _doktorService;

        public DoktorController(IDoktorService doktorService)
        {
            _doktorService = doktorService;          
        }



        [HttpGet("GetAllDoktor")]
        public IActionResult GetAll()

        {
            var result = _doktorService.GetAll();
            return Ok(result);
        }

        [HttpGet("GetByIdDoktor")]
        public IActionResult GetById(int id)

        {
            var result = _doktorService.GetById(id);
            return Ok(result);
        }

        [HttpDelete("DoktorDeleteById")]
        public IActionResult Delete(int id)

        {
            _doktorService.DeleteById(id);
            return Ok();
        }

        [HttpDelete("DoktorDelete")]
        public IActionResult Deleteaaa(Doktor doktor)

        {
            _doktorService.Delete(doktor);
            return Ok();
        }



        [HttpPost("DoktorAdd")]
        public IActionResult Add(Doktor doktor)

        {
            _doktorService.Add(doktor);
            return Ok();
        }

        [HttpPut("DoktorUpdate")]
        public IActionResult Update(Doktor doktor)

        {
            _doktorService.Update(doktor);
            return Ok();
        }


    }
}
