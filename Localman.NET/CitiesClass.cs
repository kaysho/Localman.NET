using Newtonsoft.Json;

namespace Localman.NET
{
    public class CitiesClass
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("status")]
        public long Status { get; set; }
    }
}