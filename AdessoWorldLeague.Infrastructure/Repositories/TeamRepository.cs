using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdessoWorldLeague.Infrastructure.Data;
using AdessoWorldLeague.Infrastructure.Repositories.Generic;
using AdessoWorldLeauge.Domain.Entities;
using AdessoWorldLeauge.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AdessoWorldLeague.Infrastructure.Repositories
{
    public class TeamRepository : GenericRepository<Team>, ITeamRepository
    {
        private readonly AdessoDbContext _context;
        public TeamRepository(AdessoDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
