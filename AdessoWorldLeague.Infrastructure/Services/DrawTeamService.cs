using AdessoWorldLeague.Infrastructure.Repositories;
using AdessoWorldLeauge.Domain.Entities;
using AdessoWorldLeauge.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdessoWorldLeague.Infrastructure.Services.Interfaces;
using System.Xml.Linq;

namespace AdessoWorldLeague.Infrastructure.Services
{
    public class DrawTeamService : IDrawTeamService
    {
        private readonly IGroupRepository _groupRepository;
        private readonly ITeamRepository _teamRepository;
        private readonly ICountriesRepository _countriesRepository;

        public DrawTeamService(IGroupRepository groupRepository, ITeamRepository teamRepository, ICountriesRepository countriesRepository)
        {
            _groupRepository = groupRepository;
            _teamRepository = teamRepository;
            _countriesRepository = countriesRepository;
        }

        public async Task<List<Team>> DrawTeams(DrawRequest request)
        {
            if (request.DrawerFirstName == "" || request.DrawerLastName == "")
            {
                return new List<Team>();
            }

            if (request.GroupCount != 4 && request.GroupCount != 8)
            {
                return new List<Team>();

            }

            var groupNames = new List<string> { "A", "B", "C", "D", "E", "F", "G", "H" };
            var groupsToCreate = groupNames.Take(request.GroupCount);


            for (int i = 0; i < groupsToCreate.Count(); i++)
            {
                var newGroup = new Group { Name = groupsToCreate.ElementAt(i), Teams = new List<Team>() };
                await _groupRepository.AddAsync(newGroup);
            }

            var countries = _countriesRepository.GetAllAsync();
            var groups = _groupRepository.GetAllAsync();



            var teams = countries.Result[0].Teams.ToList();
            return teams;

        }

    }
}
