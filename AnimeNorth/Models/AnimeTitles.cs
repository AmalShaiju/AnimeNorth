using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace AnimeNorth.Models
{
    public class AnimeTitles
    {
        [JsonProperty("en_jp")]
        public string EnJp { get; private set; }

        [JsonProperty("ja_jp")]
        public string JaJp { get; private set; }
    }
}
