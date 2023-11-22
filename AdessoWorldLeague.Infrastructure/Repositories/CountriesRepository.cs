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

        public async Task<Dictionary<string, List<string>>> GetTeams()
        {
            var entities = await _context.Countries
                .Include(q => q.Teams).ToListAsync();
            Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>>();

            foreach (var country in entities)
            {
                dictionary.Add(country.Name, country.Teams.Select(t => t.Name).ToList());
            }

            return dictionary;
        }
    }
}
