using AdessoWorldLeague.Infrastructure.Repositories;
using AdessoWorldLeague.Infrastructure.Responses;
using AdessoWorldLeague.Infrastructure.Services.Interfaces;
using AdessoWorldLeague.Infrastructure.Validators;
using AdessoWorldLeauge.Domain.Entities;
using AdessoWorldLeauge.Domain.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Xml;
using Formatting = Newtonsoft.Json.Formatting;

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
            DrawRequestValidator validator = new DrawRequestValidator();
            var validationResult = await validator.ValidateAsync(request);
            if (!validationResult.IsValid)
            {
                var errorMessages = validationResult.Errors
                    .Select(e => e.ErrorMessage)
                    .ToList();
                return BadRequest(errorMessages);
            }
            var response = await _drawTeamService.DrawTeams(request);
            string jsonResponse = JsonConvert.SerializeObject(new { groups = response }, Formatting.Indented);
            return Ok(jsonResponse);
        }
    }
}
