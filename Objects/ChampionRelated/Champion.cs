using System.Collections.Generic;

namespace LeagueRecommendBuild.Objects
{
    class Champion
    {
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public Image image { get; set; }
        public List<Skin> skins { get; set; }
        public string lore { get; set; }
        public string blurb { get; set; }
        public List<string> allytips { get; set; }
        public List<string> enemytips { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Info info { get; set; }
        public Stats stats { get; set; }
        public List<Spell> spells { get; set; }
        public Passive passive { get; set; }
        public List<Recommended> recommended { get; set; }
    }
}
