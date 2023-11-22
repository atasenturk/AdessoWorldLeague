using AdessoWorldLeague.Infrastructure.Repositories;
using AdessoWorldLeague.Infrastructure.Services.Interfaces;
using AdessoWorldLeauge.Domain.Entities;
using AdessoWorldLeauge.Domain.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AdessoWorldLeague.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamDrawController : ControllerBase
    {
        private readonly IDrawTeamService _drawTeamService;

        public TeamDrawController(IDrawTeamService drawTeamService)
        {
            _drawTeamService = drawTeamService;
        }

        [HttpPost("draw")]
        public async Task<IActionResult> DrawTeams([FromBody] DrawRequest request)
        {
            var message = await _drawTeamService.DrawTeams(request);
            return Ok(message);
        }
    }
}
