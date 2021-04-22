using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace AnimeNorth.Data
{
    public class AnimeRepository : IAnimeRepository
    {
        public async Task<AnimeById> GetAnimeAsync(int id)
        {
            var json = await Kitsu.Client.GetStringAsync($"{Kitsu.BaseUri}/anime/{id}");
            var anime = JsonConvert.DeserializeObject<AnimeById>(json);
            return anime;
        }
    }
}
