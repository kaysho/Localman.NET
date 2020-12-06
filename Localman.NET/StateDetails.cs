using Newtonsoft.Json;
using System.Collections.Generic;

namespace Localman.NET
{
    public class StateDetails
    {
        [JsonProperty("minLat")]
        public double MinLat { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("capital")]
        public string Capital { get; set; }

        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("minLong")]
        public double MinLong { get; set; }

        [JsonProperty("maxLat")]
        public double MaxLat { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("maxLong")]
        public double MaxLong { get; set; }

        [JsonProperty("alias")]
        public string Alias { get; set; }

        [JsonProperty("cities")]
        [JsonIgnore]
        public CitiesUnion Cities { get; set; }

        [JsonProperty("lgas")]
        public List<string> Lgas { get; set; }
    }
}
