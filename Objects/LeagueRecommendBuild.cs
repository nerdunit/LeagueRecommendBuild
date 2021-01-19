using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using LeagueRecommendBuild.Objects;
using Newtonsoft.Json.Linq;
using Newtonsoft;

namespace LeagueRecommendBuild.Objects
{
    
    class ItemWithPrice
    {
        public ItemRelated.Item item;
        public long price;
        public ItemWithPrice(ItemRelated.Item item, long price)
        {
            this.item = item;
            this.price = price;
        }
    }

    class LeagueRecommendBuild
    {
        public static List<Champion> Champions { get; set; }
        public static List<ItemRelated.Item> Items { get; set; }
        private static readonly Random random = new Random();

        public static void InitialiseChampionList()
        {
            //Initialise list as empty
            Champions = new List<Champion>();
            //Read League Champions (championFull.json) but i changed the name
            JObject leagueChampions = JObject.Parse(File.ReadAllText("championFull.json"));

            foreach (var ChampArray in leagueChampions["data"])
            {
                foreach (var Champ in ChampArray)
                {
                    //Console.WriteLine(Champ);
                    Champions.Add(Champ.ToObject<Champion>());
                    //Console.WriteLine($"Added Champion: {Champ["id"]}");
                }
            }
        }

        public static void InitialiseItemList()
        {
            Items = new List<ItemRelated.Item>();
            JObject leagueItems = JObject.Parse(File.ReadAllText("item.json"));
            foreach (var ItemsArray in leagueItems["data"])
            {
                foreach (var Item in ItemsArray)
                {
                    Items.Add(Item.ToObject<ItemRelated.Item>());
                }
            }
        }

        public static Champion RandomChampion()
        {
            return Champions[random.Next(Champions.Count)];
        }

        public static ItemRelated.Item ItemIDtoItem(string id)
        {
            foreach (var item in LeagueRecommendBuild.Items)
            {//the only way i can think of to convert
                if (string.Equals($"{id}.png",item.Image.Full))
                {
                    return item;
                }
            }
            return new ItemRelated.Item();
        }

        public static Champion ChampionNameToChampion(string name)
        {
            foreach (var champ in LeagueRecommendBuild.Champions)
            { 
                if (string.Equals(champ.name,name))
                {
                    return champ;
                }
            }
            return new Champion();
        }

        public static List<ItemRelated.Item> ItemsToBuy(Champion champion)
        {
            List<ItemRelated.Item> items = new List<ItemRelated.Item>();
            return items;
        }
    }
}
