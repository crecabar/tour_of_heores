using Microsoft.AspNetCore.Mvc;

namespace ProyectoBackend.src.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return new JsonResult("Hello from the backend!");
        }
    }
}
