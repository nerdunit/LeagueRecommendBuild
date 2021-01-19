using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace LeagueRecommendBuild
{
    class Updater
    {
        //i.e. 
        public const string lang = "en_US";
        public const string versionUrl = "https://ddragon.leagueoflegends.com/api/versions.json";
        public const string champJsonFileName = "championFull.json";
        public const string itemJsonFileName = "item.json";
        public const string versionFileName = "currentVersion.txt";
        public static string versionAvailable = "";

        public static bool UpdateAvailable()
        {
            
            
            using (var wc = new System.Net.WebClient())
            {
                string contents;
                contents = wc.DownloadString(versionUrl);
                dynamic versions = JsonConvert.DeserializeObject(contents);
                versionAvailable = versions[0];
            }


            if (File.Exists(versionFileName) == false)
                File.WriteAllText(versionFileName, "unknown");
            if (string.Equals(File.ReadAllText(versionFileName), versionAvailable))
                return false;
            return true;
        }

        public static void DoUpdate()
        {
            if (UpdateAvailable())
            {
                File.WriteAllText(versionFileName, versionAvailable);
                using (var wc = new System.Net.WebClient())
                {
                    File.WriteAllText(champJsonFileName, wc.DownloadString(
                        $"https://ddragon.leagueoflegends.com/cdn/{versionAvailable}/data/{lang}/championFull.json"));
                    File.WriteAllText(itemJsonFileName, wc.DownloadString(
                        $"https://ddragon.leagueoflegends.com/cdn/{versionAvailable}/data/{lang}/item.json"));
                }
            }
        }
    }
}
