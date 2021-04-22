using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AnimeNorth.Data
{
    public interface IAnimeRepository
    {
        Task<AnimeById> GetAnimeAsync(int id);
    }
}
