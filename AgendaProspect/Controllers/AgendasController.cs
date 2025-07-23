using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BusinessAgenda.API.Controllers
{
    [ApiController]
    [Route("api/agendas")]
    public class AgendasController : ControllerBase
    {
        private readonly IMediator _mediator;
        public AgendasController(IMediator mediator)
        {
            _mediator = mediator;
        }
        // GET api/Agenda?search=crm
        [HttpGet("{name}")]
        public IActionResult Get(string name)
        {
            //Implementacao fazer consultar agenda por nome de gerente
            return Ok();
        }
    }
}
