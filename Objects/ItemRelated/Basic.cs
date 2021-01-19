using System.Collections.Generic;
using Newtonsoft.Json;

namespace LeagueRecommendBuild.Objects.ItemRelated
{
    public partial class Basic
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("rune")]
        public Rune Rune { get; set; }

        [JsonProperty("gold")]
        public Gold Gold { get; set; }

        [JsonProperty("group")]
        public string Group { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("colloq")]
        public string Colloq { get; set; }

        [JsonProperty("plaintext")]
        public string Plaintext { get; set; }

        [JsonProperty("consumed")]
        public bool Consumed { get; set; }

        [JsonProperty("stacks")]
        public long Stacks { get; set; }

        [JsonProperty("depth")]
        public long Depth { get; set; }

        [JsonProperty("consumeOnFull")]
        public bool ConsumeOnFull { get; set; }

        [JsonProperty("from")]
        public object[] From { get; set; }

        [JsonProperty("into")]
        public object[] Into { get; set; }

        [JsonProperty("specialRecipe")]
        public long SpecialRecipe { get; set; }

        [JsonProperty("inStore")]
        public bool InStore { get; set; }

        [JsonProperty("hideFromAll")]
        public bool HideFromAll { get; set; }

        [JsonProperty("requiredChampion")]
        public string RequiredChampion { get; set; }

        [JsonProperty("requiredAlly")]
        public string RequiredAlly { get; set; }

        [JsonProperty("stats")]
        public Dictionary<string, long> Stats { get; set; }

        [JsonProperty("tags")]
        public object[] Tags { get; set; }

        [JsonProperty("maps")]
        public Dictionary<string, bool> Maps { get; set; }
    }
}
