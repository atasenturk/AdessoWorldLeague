using AdessoWorldLeague.Infrastructure.Repositories;
using AdessoWorldLeauge.Domain.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AdessoWorldLeague.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamDrawController : ControllerBase
    {
        private readonly IGroupRepository _groupRepository;
        private readonly ITeamRepository _teamRepository;
        private readonly ICountriesRepository _countriesRepository;

        public TeamDrawController(IGroupRepository groupRepository, ITeamRepository teamRepository, ICountriesRepository countriesRepository)
        {
            _groupRepository = groupRepository;
            _teamRepository = teamRepository;
            _countriesRepository = countriesRepository;
        }

        [HttpPost("teams")]
        public IActionResult DrawTeams([FromBody] DrawRequest request)
        {
            // Kurayı çekme işlemi ve cevabın dönülmesi
        }
    }
}
