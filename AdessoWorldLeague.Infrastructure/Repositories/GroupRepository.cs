using AdessoWorldLeague.Infrastructure.Repositories.Generic;
using AdessoWorldLeauge.Domain.Entities;
using AdessoWorldLeauge.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AdessoWorldLeague.Infrastructure.Data;

namespace AdessoWorldLeague.Infrastructure.Repositories
{
    public class GroupRepository : GenericRepository<Group>, IGroupRepository
    {
        private readonly AdessoDbContext _context;

        public GroupRepository(AdessoDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<bool> RemoveAllAsync()
        {
            foreach (var group in _context.Groups)
            {
                _context.Remove(group);
            }
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<List<Group>> GetGroupsByDrawId(int id)
        {
            return await _context.Groups.Where(q => q.DrawId == id).ToListAsync();
        }
    }
}
