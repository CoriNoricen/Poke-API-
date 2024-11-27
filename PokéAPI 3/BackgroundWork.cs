using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PokéAPI_3
{
    internal class BackgroundWork
    {
        public static string Player1Name;
        public static string Player2Name;
        public static int RoundCount = 6;

        public static bool MoveToEnd(int i)
        {
            if (i/2 == RoundCount)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static List<string> P1Options = new List<string>();
        public static List<string> P2Options = new List<string>();
        public static int DexNo;

        private static void FindRandom()
        {
            Random rnd = new Random();
            int dexNo = rnd.Next(1, 1025);
            DexNo = dexNo;
        }

        public static string[] ImageFinder(bool ReRandom)
        {
            string ShinyPkmn = "";

            if (ReRandom == true)
            {
                FindRandom();
            }

            Random random = new Random();
            int i = random.Next(40);
            if (i == 1)
            {
                ShinyPkmn = "shiny/";
            }

            string[] filepaths = {$"https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/{ShinyPkmn}{DexNo}.png",
                $"https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/{ShinyPkmn}{DexNo}.png"};
            return filepaths;
        }

        public static string NameRandomiser(bool ReRandom)
        {
            if (ReRandom == true)
            {
                FindRandom();
            }

            string json = new WebClient().DownloadString($"https://pokeapi.co/api/v2/pokemon-species?limit=1&offset={DexNo - 1}");
            string toBeSearched = "name\":\"";
            string code = json.Substring(json.IndexOf(toBeSearched) + toBeSearched.Length);

            string[] subs = code.Split(',');
            string ShowMe = subs[0];
            ShowMe = ShowMe.Remove(ShowMe.Length - 1);

            return ShowMe.ToUpper();
        }

        public static string DexRandomiser(bool ReRandom)
        {
            string ShowMe = "ERROR";
            if (ReRandom == true)
            {
                FindRandom();
            }

            string json = new WebClient().DownloadString($"https://pokeapi.co/api/v2/pokemon-species/{DexNo}");
            string toBeSearched = "\"flavor_text\":";
            string code = json.Substring(json.IndexOf(toBeSearched) + toBeSearched.Length);

            string[] subs = code.Split('}');
            for (int i = 0; i < subs.Length; i++)
            {
                if (subs[i].Contains("\"language\":{\"name\":\"en\""))
                {
                    ShowMe = subs[i];
                    break;
                }
            }
            return ShowMe.ToLower();
        }

        public static string[] HeightWeightRandomiser(bool ReRandom)
        {
            if (ReRandom == true)
            {
                FindRandom();
            }

            string json = new WebClient().DownloadString($"https://pokeapi.co/api/v2/pokemon/{DexNo}");
            string toBeSearched = "height\":";
            string code = json.Substring(json.IndexOf(toBeSearched) + toBeSearched.Length);

            string[] subs = code.Split(',');
            int ShowMeHeight = (Convert.ToInt32(subs[0]) * 10);
            string Show1 = Convert.ToString(ShowMeHeight) + "cm";

            toBeSearched = "weight\":";
            code = json.Substring(json.IndexOf(toBeSearched) + toBeSearched.Length);

            subs = code.Split(',');
            string ShowMeWeight = subs[0];
            ShowMeWeight = ShowMeWeight.Remove(ShowMeWeight.Length - 1);
            double ShowMeWeight2 = (Convert.ToDouble(ShowMeWeight) / 10);
            string Show2 = Convert.ToString(ShowMeWeight2) + "kg";

            return new string[] { Show1, Show2 };
        }
    }
} 
