using CinemaSeats.Application.BookSeats.Commands.BookSeats;
using CinemaSeats.Application.BookSeats.Queries.GetSeats;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CinemaSeats.WebUI.Controllers
{
    [Authorize]
    public class BookSeatsController : ApiController
    {
        [HttpGet]
        public async Task<ActionResult<BookSeatsVm>> Get()
        {
            return await Mediator.Send(new GetSeatsQuery());
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Update(int id, BookSeatsCommand command)
        {
            if (id != command.SeatsMap.Id)
            {
                return BadRequest();
            }

            await Mediator.Send(command);

            return NoContent();
        }
    }
}
