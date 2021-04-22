using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace AnimeNorth.Models
{
    public class AnimeAttributes
    {
        [JsonProperty("tba")]
        public string Tba { get; private set; }

        [JsonProperty("abbreviatedTitles")]
        public string[] AbbreviatedTitles { get; private set; }

        [JsonProperty("averageRating")]
        public string AverageRating { get; private set; }

        [JsonProperty("status")]
        public string Status { get; private set; }

        [JsonProperty("ageRating")]
        public string AgeRating { get; private set; }

        [JsonProperty("subtype")]
        public string Subtype { get; private set; }

        [JsonProperty("canonicalTitle")]
        public string CanonicalTitle { get; private set; }

        [JsonProperty("episodeLength")]
        public int? EpisodeLength { get; private set; }

        [JsonProperty("coverImage")]
        public AnimeCoverImage CoverImage { get; private set; }

        [JsonProperty("slug")]
        public string Slug { get; private set; }

        [JsonProperty("titles")]
        public AnimeTitles Titles { get; private set; }

        [JsonProperty("ageRatingGuide")]
        public string AgeRatingGuide { get; private set; }

        [JsonProperty("startDate")]
        public string StartDate { get; private set; }

        [JsonProperty("episodeCount")]
        public int? EpisodeCount { get; private set; }

        [JsonProperty("favoritesCount")]
        public int? FavoritesCount { get; private set; }

        [JsonProperty("nsfw")]
        public bool Nsfw { get; private set; }

        [JsonProperty("endDate")]
        public string EndDate { get; private set; }

        [JsonProperty("ratingRank")]
        public int? RatingRank { get; private set; }

        [JsonProperty("posterImage")]
        public AnimePosterImage PosterImage { get; private set; }

        [JsonProperty("synopsis")]
        public string Synopsis { get; private set; }

        [JsonProperty("showType")]
        public string ShowType { get; private set; }

        [JsonProperty("userCount")]
        public int? UserCount { get; private set; }

        [JsonProperty("popularityRank")]
        public int? PopularityRank { get; private set; }
    }
}
