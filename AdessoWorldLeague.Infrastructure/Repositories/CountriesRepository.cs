using AdessoWorldLeague.Infrastructure.Repositories.Generic;
using AdessoWorldLeauge.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdessoWorldLeauge.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using AdessoWorldLeague.Infrastructure.Data;

namespace AdessoWorldLeague.Infrastructure.Repositories
{
    public class CountriesRepository : GenericRepository<Country>, ICountriesRepository
    {
        private readonly AdessoDbContext _context;
        public CountriesRepository(AdessoDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
