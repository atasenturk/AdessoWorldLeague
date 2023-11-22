using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdessoWorldLeague.Infrastructure.Responses;
using AdessoWorldLeague.Infrastructure.Services.Interfaces;
using AdessoWorldLeauge.Domain.Entities;
using AdessoWorldLeauge.Domain.Interfaces;
using Moq;
using Xunit;

namespace AdessoWorldLeague.Tests.UnitTests
{
    public class DrawTeamServiceTests
    {
        [Fact]
        public async void DrawTeamsTest()
        {
            var drawTeamService = new Mock<IDrawTeamService>();
            var request = new DrawRequest
            {
                GroupCount = 4,
                DrawerFirstName = "Ata",
                DrawerLastName = "Senturk"
            };
            drawTeamService.Setup(x => x.DrawTeams(It.IsAny<DrawRequest>()))
                .ReturnsAsync(new List<GroupResponse>
                {
                    new GroupResponse { GroupName = "Group A", Teams = new List<TeamResponse>() },
                    new GroupResponse { GroupName = "Group B", Teams = new List<TeamResponse>() }
                });


            var drawService = drawTeamService.Object; 

            var result = await drawService.DrawTeams(request);

            Assert.Equal(2, result.Count); 
            Assert.Equal("Group A", result[0].GroupName); 
        }

        //TODO: will be added some tests
    }
}
