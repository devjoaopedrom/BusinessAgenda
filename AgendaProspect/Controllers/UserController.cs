using Microsoft.AspNetCore.Mvc;

namespace BusinessAgenda.API.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class UserController : Controller
    {
        // POST api/users
        [HttpPost]
        public IActionResult Post()
        {
            return Ok();
        }

    }
}
