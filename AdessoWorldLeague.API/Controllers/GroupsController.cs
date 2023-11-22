using AdessoWorldLeague.Infrastructure.Repositories;
using AdessoWorldLeauge.Domain.Entities;
using AdessoWorldLeauge.Domain.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AdessoWorldLeague.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GroupsController : ControllerBase
    {
        private readonly IGroupRepository _groupRepository;

        public GroupsController(IGroupRepository groupRepository)
        {
            _groupRepository = groupRepository;
        }

        // GET: api/Countries
        [HttpGet]
        public async Task<ActionResult> GetCountries()
        {
            var groups = await _groupRepository.GetAllAsync();
            return Ok(groups);
        }

        [HttpPost]
        public async Task<ActionResult> AddGroup()
        {
            var groups = await _groupRepository.AddAsync(new Group()
            {
                Name = "A"
            });
            return Ok(groups);
        }
    }
}
