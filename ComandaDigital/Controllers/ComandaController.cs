using Microsoft.AspNetCore.Mvc;

namespace ComandaDigital.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ComandaController : Controller
    {
        public ComandaController()
        {
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Hello World");
        }
    }
}