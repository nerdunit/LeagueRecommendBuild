using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using LeagueRecommendBuild.Objects;
using Newtonsoft.Json.Linq;
using Newtonsoft;

namespace LeagueRecommendBuild
{
    class Program
    {
        static void Main(string[] args)
        {
            //Update jsons containing items and champions
            Updater.DoUpdate();

            Objects.LeagueRecommendBuild.InitialiseChampionList();
            Objects.LeagueRecommendBuild.InitialiseItemList();

            foreach (var champ in Objects.LeagueRecommendBuild.Champions)
            {
                Console.WriteLine(champ.name);
                foreach (var item in ItemsToBuy(champ))
                {
                    Console.WriteLine($"Name: {item.item.Name} Price:{item.price}");
                }
                Console.WriteLine("------------------------------------");
            }

            Console.ReadKey();
        }

        public static List<ItemWithPrice> ItemsToBuy(Champion champion)
        {
            Console.WriteLine($"Champion: {champion.name}");
            //By finished item i mean full items like trinity force rabadon etc
            List<Objects.ItemRelated.Item> finishedItems = new List<Objects.ItemRelated.Item>();
            List<ItemWithPrice> items = new List<ItemWithPrice>();

            //get recommended items from json
            Recommended recommended = new Recommended();
            foreach (var Recommandation in champion.recommended)
            {
                if (Recommandation.map == "SR" && Recommandation.mode == "CLASSIC")
                {
                    recommended = Recommandation;
                    break;
                }
            }

            //
            int i = 0;
            foreach (var block in recommended.blocks)
            {
                //Check if items are "full"
                if (block.type == "essential" || block.type == "aggressive" || block.type == "standard" || block.type == "offensive")
                {
                    foreach (var item1 in block.items)
                    {
                        if (i == 6) //only get 6 items
                            break;
                        var item = Objects.LeagueRecommendBuild.ItemIDtoItem(item1.id); //convert item from champs json to item json which has more info
                        if (item.Maps != null && item.Maps["11"] == true) //if map is summoner's rift
                        {
                            //Console.WriteLine($"{item.Name}");
                            finishedItems.Add(item);
                            i++;
                        }
                    }
                }
            }

            foreach (var finishedItem in finishedItems)
            {
                foreach (long id in finishedItem.From) //item ids that the main item is made from
                {
                    var item = Objects.LeagueRecommendBuild.ItemIDtoItem($"{id}");
                    if (item.From != null)
                    {
                        for (int j = 0; j < item.From.Length; j++)
                        {
                            var itm = Objects.LeagueRecommendBuild.ItemIDtoItem($"{item.From[j]}");
                            items.Add(new ItemWithPrice(itm, itm.Gold.Base));
                            //Console.WriteLine(LeagueBot.ItemIDtoItem($"{item.From[j]}").Name);
                        }
                    }
                    items.Add(new ItemWithPrice(item, item.Gold.Base));
                    //Console.WriteLine(item.Name);
                }
                items.Add(new ItemWithPrice(finishedItem, finishedItem.Gold.Base));
            }

            return items;
        }
    }
}
