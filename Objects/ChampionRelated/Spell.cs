using System.Collections.Generic;

namespace LeagueRecommendBuild.Objects
{
    public class Spell
    {
        public string id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string tooltip { get; set; }
        public Leveltip leveltip { get; set; }
        public int maxrank { get; set; }
        public List<int> cooldown { get; set; }
        public string cooldownBurn { get; set; }
        public List<int> cost { get; set; }
        public string costBurn { get; set; }
        public Datavalues datavalues { get; set; }
        public List<List<int>> effect { get; set; }
        public List<string> effectBurn { get; set; }
        public List<object> vars { get; set; }
        public string costType { get; set; }
        public string maxammo { get; set; }
        public List<int> range { get; set; }
        public string rangeBurn { get; set; }
        public Image image { get; set; }
        public string resource { get; set; }
    }
}
