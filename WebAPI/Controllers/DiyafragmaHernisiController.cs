using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiyafragmaHernisiController : ControllerBase
    {
        IDiyafragmaHernisiService _diyafragmahernisiService;

        public DiyafragmaHernisiController(IDiyafragmaHernisiService diyafragmahernisiService)
        {
            _diyafragmahernisiService = diyafragmahernisiService;
        }

        [HttpGet("GetAllDiyafragmaHernisi")]
        public IActionResult GetAll()

        {
            var result = _diyafragmahernisiService.GetAll();
            return Ok(result);
        }

        [HttpGet("GetByIdDiyafragmaHernisi")]
        public IActionResult GetById(int id)

        {
            var result = _diyafragmahernisiService.GetById(id);
            return Ok(result);
        }

        [HttpDelete("DiyafragmaHernisiDeleteById")]
        public IActionResult Delete(int id)

        {
            _diyafragmahernisiService.DeleteById(id);
            return Ok();
        }

        [HttpDelete("DiyafragmaHernisiDelete")]
        public IActionResult Deleteaaa(DiyafragmaHernisi diyafragmahernisi)

        {
            _diyafragmahernisiService.Delete(diyafragmahernisi);
            return Ok();
        }

        [HttpPost("DiyafragmaHernisiAdd")]
        public IActionResult Add(DiyafragmaHernisi diyafragmahernisi)

        {
            _diyafragmahernisiService.Add(diyafragmahernisi);
            return Ok();
        }

        [HttpPut("DiyafragmaHernisiUpdate")]
        public IActionResult Update(DiyafragmaHernisi diyafragmahernisi)

        {
            _diyafragmahernisiService.Update(diyafragmahernisi);
            return Ok();
        }
    }
}
