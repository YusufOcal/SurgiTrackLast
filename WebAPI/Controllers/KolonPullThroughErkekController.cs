using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KolonPullThroughErkekController : ControllerBase
    {
        IKolonPullThroughErkekService _kolonpullthrougherkekService;

        public KolonPullThroughErkekController(IKolonPullThroughErkekService kolonpullthrougherkekService)
        {
            _kolonpullthrougherkekService = kolonpullthrougherkekService;
        }

        [HttpGet("GetAllKolonPullThroughErkek")]
        public IActionResult GetAll()

        {
            var result = _kolonpullthrougherkekService.GetAll();
            return Ok(result);
        }

        [HttpGet("GetByIdKolonPullThroughErkek")]
        public IActionResult GetById(int id)

        {
            var result = _kolonpullthrougherkekService.GetById(id);
            return Ok(result);
        }

        [HttpDelete("KolonPullThroughErkekDeleteById")]
        public IActionResult Delete(int id)

        {
            _kolonpullthrougherkekService.DeleteById(id);
            return Ok();
        }

        [HttpDelete("KolonPullThroughErkekDelete")]
        public IActionResult Deleteaaa(KolonPullThroughErkek kolonpullthrougherkek)

        {
            _kolonpullthrougherkekService.Delete(kolonpullthrougherkek);
            return Ok();
        }

        [HttpPost("KolonPullThroughErkekAdd")]
        public IActionResult Add(KolonPullThroughErkek kolonpullthrougherkek)

        {
            _kolonpullthrougherkekService.Add(kolonpullthrougherkek);
            return Ok();
        }

        [HttpPut("KolonPullThroughErkekUpdate")]
        public IActionResult Update(KolonPullThroughErkek kolonpullthrougherkek)

        {
            _kolonpullthrougherkekService.Update(kolonpullthrougherkek);
            return Ok();
        }
    }
}
