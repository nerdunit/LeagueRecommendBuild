using System.Collections.Generic;
using Newtonsoft.Json;


namespace LeagueRecommendBuild.Objects.ItemRelated
{
    public partial class Item
    {

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("colloq")]
        public string Colloq { get; set; }

        [JsonProperty("plaintext")]
        public string Plaintext { get; set; }

        [JsonProperty("into", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(DecodeArrayConverter))]
        public long[] Into { get; set; }

        [JsonProperty("image")]
        public Image Image { get; set; }

        [JsonProperty("gold")]
        public Gold Gold { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("maps")]
        public Dictionary<string, bool> Maps { get; set; }

        [JsonProperty("stats")]
        public Dictionary<string, double> Stats { get; set; }

        [JsonProperty("inStore", NullValueHandling = NullValueHandling.Ignore)]
        public bool? InStore { get; set; }

        [JsonProperty("from", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(DecodeArrayConverter))]
        public long[] From { get; set; }

        [JsonProperty("effect", NullValueHandling = NullValueHandling.Ignore)]
        public Effect Effect { get; set; }

        [JsonProperty("depth", NullValueHandling = NullValueHandling.Ignore)]
        public long? Depth { get; set; }

        [JsonProperty("stacks", NullValueHandling = NullValueHandling.Ignore)]
        public long? Stacks { get; set; }

        [JsonProperty("consumed", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Consumed { get; set; }

        [JsonProperty("hideFromAll", NullValueHandling = NullValueHandling.Ignore)]
        public bool? HideFromAll { get; set; }

        [JsonProperty("consumeOnFull", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ConsumeOnFull { get; set; }

        [JsonProperty("specialRecipe", NullValueHandling = NullValueHandling.Ignore)]
        public long? SpecialRecipe { get; set; }

        [JsonProperty("requiredChampion", NullValueHandling = NullValueHandling.Ignore)]
        public string RequiredChampion { get; set; }

        [JsonProperty("requiredAlly", NullValueHandling = NullValueHandling.Ignore)]
        public RequiredAlly? RequiredAlly { get; set; }
    }
}
