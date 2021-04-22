using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace AnimeNorth.Models
{
    public class AnimePosterImage
    {
        [JsonProperty("tiny")]
        public string Tiny { get; private set; }

        [JsonProperty("small")]
        public string Small { get; private set; }

        [JsonProperty("medium")]
        public string Medium { get; private set; }

        [JsonProperty("large")]
        public string Large { get; private set; }

        [JsonProperty("original")]
        public string Original { get; private set; }
    }
}
