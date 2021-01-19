using Newtonsoft.Json;

namespace LeagueRecommendBuild.Objects.ItemRelated
{
    public partial class Effect
    {
        [JsonProperty("Effect1Amount")]
        public string Effect1Amount { get; set; }

        [JsonProperty("Effect2Amount", NullValueHandling = NullValueHandling.Ignore)]
        public string Effect2Amount { get; set; }

        [JsonProperty("Effect3Amount", NullValueHandling = NullValueHandling.Ignore)]
        public string Effect3Amount { get; set; }

        [JsonProperty("Effect4Amount", NullValueHandling = NullValueHandling.Ignore)]
        public string Effect4Amount { get; set; }

        [JsonProperty("Effect5Amount", NullValueHandling = NullValueHandling.Ignore)]
        public string Effect5Amount { get; set; }

        [JsonProperty("Effect6Amount", NullValueHandling = NullValueHandling.Ignore)]
        public string Effect6Amount { get; set; }

        [JsonProperty("Effect7Amount", NullValueHandling = NullValueHandling.Ignore)]
        public string Effect7Amount { get; set; }

        [JsonProperty("Effect8Amount", NullValueHandling = NullValueHandling.Ignore)]
        public string Effect8Amount { get; set; }

        [JsonProperty("Effect9Amount", NullValueHandling = NullValueHandling.Ignore)]
        public string Effect9Amount { get; set; }

        [JsonProperty("Effect10Amount", NullValueHandling = NullValueHandling.Ignore)]
        public string Effect10Amount { get; set; }

        [JsonProperty("Effect11Amount", NullValueHandling = NullValueHandling.Ignore)]
        public string Effect11Amount { get; set; }

        [JsonProperty("Effect12Amount", NullValueHandling = NullValueHandling.Ignore)]
        public string Effect12Amount { get; set; }

        [JsonProperty("Effect13Amount", NullValueHandling = NullValueHandling.Ignore)]
        public string Effect13Amount { get; set; }

        [JsonProperty("Effect14Amount", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? Effect14Amount { get; set; }

        [JsonProperty("Effect15Amount", NullValueHandling = NullValueHandling.Ignore)]
        public string Effect15Amount { get; set; }

        [JsonProperty("Effect16Amount", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? Effect16Amount { get; set; }

        [JsonProperty("Effect17Amount", NullValueHandling = NullValueHandling.Ignore)]
        public string Effect17Amount { get; set; }

        [JsonProperty("Effect18Amount", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? Effect18Amount { get; set; }
    }
}
