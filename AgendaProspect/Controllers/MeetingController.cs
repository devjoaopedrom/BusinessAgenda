using BusinessAgenda.Application.Comnmand.CreatedEvent;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace BusinessAgenda.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MeetingController : ControllerBase
    {
        private readonly IMediator _mediator;
        public MeetingController(IMediator mediator)
        {
            _mediator = mediator;
        }
        // GET api/Meeting/1234

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            //Implementacao consultar das infos do evento por ID\

            return Ok();

        }
            // GET api/Meeting/by-date/{date}
        [HttpGet("by-date/{date:datetime}")]
        public IActionResult GetByDate(DateTime date)
        {
            //Implementacao trazer reunioes mes selecionado
            return Ok();
        }

        // GET api/Meeting/manager/{nameManager}
        [HttpGet("manager/{nameManager}")]
        public IActionResult GetByManager(string nameManager)
        {
            //implementacao trazer reuniao agendadas de um gerente
            return Ok();
        }
        // POST api/Meeting
        [HttpPost]
        public async Task<IActionResult> Post(CreatedMeetingCommand command)
        {
            var result = await _mediator.Send(command);

            if (!result.IsSuccess)
            {
                return BadRequest(result.Message);
            }

            return CreatedAtAction(nameof(GetById), new { result.Data }, command);
        }

        // PUT api/Meeting/cancelled
        [HttpPut("{id}/cancelled")]
        public IActionResult Put(int id) 
        {
            //implementacao cancelar uma reuniao.

            return NoContent();
        }
    }
}
