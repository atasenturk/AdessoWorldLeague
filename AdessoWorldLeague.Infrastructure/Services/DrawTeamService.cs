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
using AdessoWorldLeague.Infrastructure.Responses;
using Microsoft.EntityFrameworkCore;

namespace AdessoWorldLeague.Infrastructure.Services
{
    public class DrawTeamService : IDrawTeamService
    {
        private readonly IGroupRepository _groupRepository;
        private readonly ITeamRepository _teamRepository;
        private readonly ICountriesRepository _countriesRepository;
        private readonly IDrawRepository _drawRepository;

        public DrawTeamService(IGroupRepository groupRepository, ITeamRepository teamRepository, ICountriesRepository countriesRepository, IDrawRepository drawRepository)
        {
            _groupRepository = groupRepository;
            _teamRepository = teamRepository;
            _countriesRepository = countriesRepository;
            _drawRepository = drawRepository;
        }

        public async Task<List<GroupResponse>> DrawTeams(DrawRequest request)
        {
            var groupNames = new List<string> { "A", "B", "C", "D", "E", "F", "G", "H" };
            var groupsToCreate = groupNames.Take(request.GroupCount);


            var countriesWithTeams = await _countriesRepository.GetTeams();
            var groupsWithTeams = CreateGroups(countriesWithTeams, request.GroupCount);

            Draw draw = new Draw()
            {
                drawerFirstName = request.DrawerFirstName,
                drawerLastName = request.DrawerLastName,
                drawDate = DateTime.Now
            };
            await _drawRepository.AddAsync(draw);

            for (int i = 0; i < groupsToCreate.Count(); i++)
            {
                var newGroup = new Group { Name = groupsToCreate.ElementAt(i), Teams = new List<Team>() };

                var teamNamesInGroup = groupsWithTeams[i];

                foreach (var teamName in teamNamesInGroup)
                {
                    var team = await _teamRepository.FindByNameAsync(teamName);
                    if (team != null)
                    {
                        newGroup.Teams.Add(team);
                    }
                }
                newGroup.Draw = draw;
                await _groupRepository.AddAsync(newGroup);

            }

            var groupsResponse = groupsWithTeams
                .Select((group, index) => new GroupResponse
                {
                    GroupName = groupNames[index],
                    Teams = group.Select(teamName => new TeamResponse { Name = teamName }).ToList()
                })
                .ToList();
            WriteGroups(groupsResponse);
            return groupsResponse;

        }

        public async Task<List<Group>> GetLastDraw()
        {
            var entity = await _drawRepository.LastItem();
            var groups = await _groupRepository.GetGroupsByDrawId(entity.Id);
            return groups;
        }

        public List<List<string>> CreateGroups(Dictionary<string, List<string>> teams, int groupCount)
        {
            var groups = new List<List<string>>();
            for (int i = 0; i < groupCount; i++)
            {
                groups.Add(new List<string>());
            }

            var teamList = new List<string>(teams.Values.SelectMany(x => x));
            var random = new Random();

            while (teamList.Count > 0)
            {
                for (int i = 0; i < groupCount; i++)
                {
                    if (teamList.Count == 0) break;

                    string selectedTeam;
                    do
                    {
                        selectedTeam = teamList[random.Next(teamList.Count)];
                    }
                    while (groups[i].Any(t => teams.Any(c => c.Value.Contains(t) && c.Value.Contains(selectedTeam))));

                    groups[i].Add(selectedTeam);
                    teamList.Remove(selectedTeam);
                }
            }

            return groups;
        }

        public void WriteGroups(List<GroupResponse> groups)
        {
            string filePath = "GroupDrawResults.txt";

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (var group in groups)
                {
                    writer.WriteLine($"Group Name: {group.GroupName}");

                    foreach (var team in group.Teams)
                    {
                        writer.WriteLine($"- {team.Name}");
                    }
                    writer.WriteLine();
                }
            }
        }


    }
}
