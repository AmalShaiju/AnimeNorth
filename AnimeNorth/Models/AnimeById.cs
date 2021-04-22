using System;
using System.Collections.Generic;
using System.Text;
using AnimeNorth.Models;
using Newtonsoft.Json;

namespace AnimeNorth.Data
{
    public class AnimeById 
    {
        [JsonProperty("data")]
        public AnimeData Data { get; private set; }

        [JsonProperty("errors")]
        public AnimeErrors[] Errors { get; private set; } = { };
    }
}
