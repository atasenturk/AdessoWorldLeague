using AdessoWorldLeauge.Domain.Entities;
using AdessoWorldLeauge.Domain.Interfaces.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdessoWorldLeauge.Domain.Interfaces
{
    public interface IDrawRepository : IGenericRepository<Draw>
    {
        Task<Draw> LastItem();
    }
}
