using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdessoWorldLeauge.Domain.Entities
{
    public class Team : BaseEntity
    {
        public string Name { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }
        public int? GroupId { get; set; }
        public Group Group { get; set; }
    }

}
