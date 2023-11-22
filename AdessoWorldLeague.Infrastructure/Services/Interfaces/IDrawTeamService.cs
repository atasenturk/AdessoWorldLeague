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
        Task<List<Team>> DrawTeams(DrawRequest request);
    }
}
