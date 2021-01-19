using Newtonsoft.Json;

namespace LeagueRecommendBuild.Objects.ItemRelated
{
    public partial class Gold
    {
        [JsonProperty("base")]
        public long Base { get; set; }

        [JsonProperty("total")]
        public long Total { get; set; }

        [JsonProperty("sell")]
        public long Sell { get; set; }

        [JsonProperty("purchasable")]
        public bool Purchasable { get; set; }
    }
}
