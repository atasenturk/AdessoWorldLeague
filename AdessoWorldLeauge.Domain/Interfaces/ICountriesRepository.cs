using AdessoWorldLeauge.Domain.Interfaces.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdessoWorldLeauge.Domain.Entities;

namespace AdessoWorldLeague.Infrastructure.Repositories
{
    public interface ICountriesRepository : IGenericRepository<Country>
    {
        IQueryable<Country> GetTeams();
    }
}
