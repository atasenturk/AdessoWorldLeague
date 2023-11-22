using Newtonsoft.Json;

namespace AdessoWorldLeague.Infrastructure.Responses;

public class TeamResponse
{
    [JsonProperty("name")]
    public string Name { get; set; }
}