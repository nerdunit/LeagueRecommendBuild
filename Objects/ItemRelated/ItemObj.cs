using System.Collections.Generic;
using Newtonsoft.Json;

namespace LeagueRecommendBuild.Objects.ItemRelated
{
    public partial class ItemObj
    {
        [JsonProperty("type")]
        public TypeEnum Type { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("basic")]
        public Basic Basic { get; set; }

        [JsonProperty("data")]
        public Dictionary<string, Item> Items { get; set; }

        [JsonProperty("groups")]
        public Group[] Groups { get; set; }

        [JsonProperty("tree")]
        public Tree[] Tree { get; set; }
    }
}
