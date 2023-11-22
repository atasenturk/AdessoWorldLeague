using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace AdessoWorldLeague.Infrastructure.Responses
{
    public class GroupResponse
    {
        [JsonProperty("groupName")]
        public string GroupName { get; set; }
        [JsonProperty("teams")]
        public List<TeamResponse> Teams { get; set; }
    }
}
