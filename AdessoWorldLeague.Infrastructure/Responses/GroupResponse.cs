using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace AdessoWorldLeague.Infrastructure.Responses
{
    // Represents a response object that contains information about a group.
    public class GroupResponse
    {
        // Gets or sets the name of the group.
        [JsonProperty("groupName")]
        public string GroupName { get; set; }

        // Gets or sets the list of team responses within the group.
        [JsonProperty("teams")]
        public List<TeamResponse> Teams { get; set; }
    }
}