using System.Collections.Generic;
using Newtonsoft.Json;

namespace AnimeNorth.Models
{
    public class AnimeData 
    {
        [JsonProperty("id")]
        public string Id { get; private set; }
        
        [JsonProperty("type")]
        public string Type { get; private set; }
        
        [JsonProperty("attributes")]
        public AnimeAttributes Attributes { get; private set; }
    }

}