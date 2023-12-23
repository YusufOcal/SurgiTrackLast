using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HastaController : ControllerBase
    {
        IHastaService _hastaService;

        public HastaController(IHastaService hastaService)
        {
            _hastaService = hastaService;
        }




        [HttpGet("GetAllHasta")]
        public IActionResult GetAll()

        {
            var result = _hastaService.GetAll();
            return Ok(result);
        }

        [HttpGet("GetByIdHasta")]
        public IActionResult GetById(int id)

        {
            var result = _hastaService.GetById(id);
            return Ok(result);
        }

        [HttpDelete("HastaDeleteById")]
        public IActionResult Delete(int id)

        {
            _hastaService.DeleteById(id);
            return Ok();
        }

        [HttpDelete("HastaDelete")]
        public IActionResult Deleteaaa(Hasta hasta)

        {
            _hastaService.Delete(hasta);
            return Ok();
        }



        [HttpPost("HastaAdd")]
        public IActionResult Add(Hasta hasta)

        {
            _hastaService.Add(hasta);
            return Ok();
        }

        [HttpPut("HastaUpdate")]
        public IActionResult Update(Hasta hasta)

        {
            _hastaService.Update(hasta);
            return Ok();
        }


    }
}
