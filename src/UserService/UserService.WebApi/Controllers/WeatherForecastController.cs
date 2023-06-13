using MediatR;
using Microsoft.AspNetCore.Mvc;
using UserService.Application.CQRS.Command.Authorization;

namespace UserService.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IMediator mediator;

        public WeatherForecastController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet("GetAuto")]
        public async Task<IActionResult> GetDowload(string login, string password)
        {
            var content = new GetAutCommand
            {
               login = login,
               password = password
            };
            var answer = await mediator.Send(content);
            return Ok(answer);
        }
    }
}