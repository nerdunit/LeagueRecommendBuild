using System.Collections.Generic;

namespace LeagueRecommendBuild.Objects
{
    public class Block
    {
        public string type { get; set; }
        public bool recMath { get; set; }
        public bool recSteps { get; set; }
        public int minSummonerLevel { get; set; }
        public int maxSummonerLevel { get; set; }
        public string showIfSummonerSpell { get; set; }
        public string hideIfSummonerSpell { get; set; }
        public string appendAfterSection { get; set; }
        public List<string> visibleWithAllOf { get; set; }
        public List<string> hiddenWithAnyOf { get; set; }
        public List<Item> items { get; set; }
    }
}
