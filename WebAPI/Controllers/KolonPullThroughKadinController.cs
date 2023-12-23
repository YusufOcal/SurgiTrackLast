using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KolonPullThroughKadinController : ControllerBase
    {
        IKolonPullThroughKadinService _kolonpullthroughkadinService;

        public KolonPullThroughKadinController(IKolonPullThroughKadinService kolonpullthroughkadinService)
        {
            _kolonpullthroughkadinService = kolonpullthroughkadinService;
        }

        [HttpGet("GetAllKolonPullThroughKadin")]
        public IActionResult GetAll()

        {
            var result = _kolonpullthroughkadinService.GetAll();
            return Ok(result);
        }

        [HttpGet("GetByIdKolonPullThroughKadin")]
        public IActionResult GetById(int id)

        {
            var result = _kolonpullthroughkadinService.GetById(id);
            return Ok(result);
        }

        [HttpDelete("KolonPullThroughKadinDeleteById")]
        public IActionResult Delete(int id)

        {
            _kolonpullthroughkadinService.DeleteById(id);
            return Ok();
        }

        [HttpDelete("KolonPullThroughKadinDelete")]
        public IActionResult Deleteaaa(KolonPullThroughKadin kolonpullthroughkadin)

        {
            _kolonpullthroughkadinService.Delete(kolonpullthroughkadin);
            return Ok();
        }

        [HttpPost("KolonPullThroughKadinAdd")]
        public IActionResult Add(KolonPullThroughKadin kolonpullthroughkadin)

        {
            _kolonpullthroughkadinService.Add(kolonpullthroughkadin);
            return Ok();
        }

        [HttpPut("KolonPullThroughKadinUpdate")]
        public IActionResult Update(KolonPullThroughKadin kolonpullthroughkadin)

        {
            _kolonpullthroughkadinService.Update(kolonpullthroughkadin);
            return Ok();
        }
    }
}
