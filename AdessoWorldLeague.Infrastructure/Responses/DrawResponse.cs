using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdessoWorldLeague.Infrastructure.Responses
{
    public class DrawResponse
    {
        public string DrawerFirstName { get; set; }
        public string DrawerLastName { get; set; }
        public List<GroupResponse> Groups { get; set; } 
    }
}
