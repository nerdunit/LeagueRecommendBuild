using Newtonsoft.Json;

namespace LeagueRecommendBuild.Objects.ItemRelated
{
    public partial class Rune
    {
        [JsonProperty("isrune")]
        public bool Isrune { get; set; }

        [JsonProperty("tier")]
        public long Tier { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
