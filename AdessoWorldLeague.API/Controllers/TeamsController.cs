using AdessoWorldLeague.Infrastructure.Repositories;
using AdessoWorldLeauge.Domain.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AdessoWorldLeague.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamsController : ControllerBase
    {
        private readonly ITeamRepository _teamRepository;

        public TeamsController(ITeamRepository teamRepository)
        {
            _teamRepository = teamRepository;
        }

        // GET: api/Countries
        [HttpGet]
        public async Task<ActionResult> GetTeams()
        {
            var teams = await _teamRepository.GetAllAsync();
            return Ok(teams);
        }
    }
}
