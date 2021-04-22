using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace AnimeNorth.Models
{
    public class AnimeErrors
    {
        [JsonProperty("title")]
        public string Title { get; private set; }

        [JsonProperty("detail")]
        public string Detail { get; private set; }

        [JsonProperty("code")]
        public string Code { get; private set; }

        [JsonProperty("status")]
        public string Status { get; private set; }
    }
}
