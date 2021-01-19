using System.Collections.Generic;

namespace LeagueRecommendBuild.Objects
{
    public class Recommended
    {
        public string champion { get; set; }
        public string title { get; set; }
        public string map { get; set; }
        public string mode { get; set; }
        public string type { get; set; }
        public string customTag { get; set; }
        public int sortrank { get; set; }
        public bool extensionPage { get; set; }
        public bool useObviousCheckmark { get; set; }
        public object customPanel { get; set; }
        public List<Block> blocks { get; set; }
        public string requiredPerk { get; set; }
        public bool? priority { get; set; }
        public string customPanelCurrencyType { get; set; }
        public string customPanelBuffCurrencyName { get; set; }
        public bool? extenOrnnPage { get; set; }
    }
}
