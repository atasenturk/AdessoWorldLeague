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
    public class DrawsController : ControllerBase
    {
        private readonly IDrawRepository _drawRepository;
        private readonly IDrawTeamService _drawTeamService;


        public DrawsController(IDrawRepository drawRepository, IDrawTeamService drawTeamService)
        {
            _drawRepository = drawRepository;
            _drawTeamService = drawTeamService;
        }

        [HttpGet]
        public async Task<List<Group>> LastDraw()
        {
            return await _drawTeamService.GetLastDraw();
        }

    }
}
