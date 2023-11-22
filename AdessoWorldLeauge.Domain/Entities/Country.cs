using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdessoWorldLeauge.Domain.Entities
{
    public class Country : BaseEntity
    {
        public Country()
        {
            Teams = new HashSet<Team>();
        }
        public string Name { get; set; }
        public ICollection<Team> Teams { get; set; }
    }
}
