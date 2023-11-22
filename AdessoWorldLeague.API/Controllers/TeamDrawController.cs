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
    // The controller responsible for handling team draw-related operations.
    [Route("api/[controller]")]
    [ApiController]
    public class TeamDrawController : ControllerBase
    {
        private readonly IDrawTeamService _drawTeamService;

        // Constructor to inject the draw team service.
        public TeamDrawController(IDrawTeamService drawTeamService)
        {
            _drawTeamService = drawTeamService;
        }

        // POST endpoint to draw teams into groups based on a request.
        [HttpPost("draw")]
        public async Task<IActionResult> DrawTeams([FromBody] DrawRequest request)
        {
            // Create a validator for the draw request.
            DrawRequestValidator validator = new DrawRequestValidator();
            // Validate the request.
            var validationResult = await validator.ValidateAsync(request);
            if (!validationResult.IsValid)
            {
                // If the request is not valid, return a BadRequest response with error messages.
                var errorMessages = validationResult.Errors
                    .Select(e => e.ErrorMessage)
                    .ToList();
                return BadRequest(errorMessages);
            }

            // Call the draw team service to draw teams and generate a response.
            var response = await _drawTeamService.DrawTeams(request);

            // Serialize the response as JSON with formatting.
            string jsonResponse = JsonConvert.SerializeObject(new { groups = response }, Formatting.Indented);

            // Return an OK response with the JSON result.
            return Ok(jsonResponse);
        }
    }
}
