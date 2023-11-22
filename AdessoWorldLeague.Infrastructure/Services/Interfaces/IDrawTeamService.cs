using AdessoWorldLeague.Infrastructure.Responses;
using AdessoWorldLeauge.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdessoWorldLeague.Infrastructure.Services.Interfaces
{
    public interface IDrawTeamService
    {
        Task<List<GroupResponse>> DrawTeams(DrawRequest request);
    }
}
