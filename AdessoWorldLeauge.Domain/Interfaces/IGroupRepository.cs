using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdessoWorldLeauge.Domain.Entities;
using AdessoWorldLeauge.Domain.Interfaces.Generic;

namespace AdessoWorldLeauge.Domain.Interfaces
{
    public interface IGroupRepository : IGenericRepository<Group>
    {
        Task<bool> RemoveAllAsync();
        Task<List<Group>> GetGroupsByDrawId(int id);
    }
}
