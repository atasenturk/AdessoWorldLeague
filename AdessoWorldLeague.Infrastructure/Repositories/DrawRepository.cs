using AdessoWorldLeague.Infrastructure.Repositories.Generic;
using AdessoWorldLeauge.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdessoWorldLeague.Infrastructure.Data;
using AdessoWorldLeague.Infrastructure.Responses;
using AdessoWorldLeauge.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace AdessoWorldLeague.Infrastructure.Repositories
{
    public class DrawRepository : GenericRepository<Draw>, IDrawRepository
    {
        private readonly AdessoDbContext _context;
        public DrawRepository(AdessoDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Draw> LastItem()
        {
            return await _context.Draws.OrderBy(q=>q.Id).LastAsync();
        }


    }
}
