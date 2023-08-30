using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Text_Based_RPG_Epic_Edition_2._0.Dialogue
{
    internal class FindingATown
    {
        internal static void Start()
        {

            int maxTowns = MaxTowns();

            Random random = new Random();
            int randomTown = random.Next(0, maxTowns);

            int townCount = 0;

            if (townCount <= 0)
            {
                GenerateTowns(townCount);
            }
            else
            {
                FindTownDialogue();
            }
            Console.ReadKey();
        }

        static void FindTownDialogue()
        {
            Console.WriteLine("Do you wan't to find a town?");
            Console.WriteLine("         ( Y / N )          ");
            string Input = Console.ReadKey(true).Key.ToString().ToLower();

            bool isFindingTown = true;
            while (isFindingTown == true)
            {
                if (Input == "y")
                {
                    //SelectTown();
                    isFindingTown = false;
                }
                else if (Input == "n")
                {
                    // Put something here later
                    // Maybe adventure
                }
                else
                    Console.WriteLine("Invalid Input");
            }
        }

        static int MaxTowns()
        {
            bool newRandom = true;

            if (newRandom = true)
            {
                Random random = new Random();
                int maxTowns = random.Next(25, 100);
                return maxTowns;
            }
            else
                return MaxTowns();
        }

        static void GenerateTowns(int townCount)
        {
            Random random = new Random();

            int maxTowns = MaxTowns();

            List<string> townNames = new List<string>
            {
                "Stonehaven", "Windmere", "Ironridge", "Willowbrook", "Amberwood", "Silverpeak", "Thundertop", "Ravenwood", "Goldcrest", "Shadowfen",
                "Oakhaven", "Mistwood", "Dragonholt", "Blackwater", "Willowdale", "Frostholme", "Amberhill", "Ironwood", "Stormridge", "Silverbrook",
                "Ravenspire", "Goldfield", "Shadowvale", "Thornridge", "Emberfall", "Dragonreach", "Blackstone", "Windhaven", "Moonbrook", "Snowcrest",
                "Amberglade", "Ironhold", "Stormwatch", "Silverglen", "Ravenshadow", "Goldhaven", "Thornwood", "Emberwood", "Dragonwood", "Blackhill",
                "Windkeep", "Moonlight", "Snowhaven", "Amberstone", "Ironbourne", "Stormfield", "Silvermere", "Goldridge", "Thornvale", "Emberhill",
                "Dragonridge", "Blackwood", "Windridge", "Moonshadow", "Snowfield", "Amberdale", "Ironbrook", "Stormvale", "Silverfall", "Goldwood",
                "Thornholme", "Emberbrook", "Dragonvale", "Blackridge", "Windwood", "Moonvale", "Snowbrook", "Ambershadow", "Ironvale", "Stormbrook",
                "Silverwood", "Goldholme", "Thornreach", "Emberglade", "Dragonholme", "Blackvale", "Windholme", "Moonreach", "Snowholme", "Amberreach",
                "Ironhaven", "Stormmere", "Silverdale", "Goldshadow", "Thornwood", "Emberwood", "Dragonridge", "Blackhill", "Windkeep", "Moonlight",
                "Snowhaven", "Amberstone", "Ironbourne", "Stormfield", "Silvermere", "Goldhaven", "Thornwood", "Emberwood", "Dragonridge", "Blackwood",
                "Windridge", "Moonshadow", "Snowfield", "Amberdale", "Ironbrook", "Stormvale", "Silverfall", "Goldwood", "Thornholme", "Emberbrook",
                "Dragonvale", "Blackridge", "Windwood", "Moonvale", "Snowbrook", "Ambershadow", "Ironvale", "Stormbrook", "Silverwood", "Goldholme",
                "Thornreach", "Emberglade", "Dragonholme", "Blackvale", "Windholme", "Moonreach", "Snowholme", "Amberreach", "Ironhaven", "Stormmere",
                "Silverdale", "Goldshadow", "Thornwood", "Emberwood", "Dragonridge", "Blackhill", "Windkeep", "Moonlight", "Snowhaven", "Amberstone",
                "Ironbourne", "Stormfield", "Silvermere", "Goldhaven", "Thornwood", "Emberwood", "Dragonridge", "Blackwood", "Windridge", "Moonshadow",
                "Snowfield", "Amberdale", "Ironbrook", "Stormvale", "Silverfall", "Goldwood", "Thornholme", "Emberbrook", "Dragonvale", "Blackridge",
                "Windwood", "Moonvale", "Snowbrook", "Ambershadow", "Ironvale", "Stormbrook", "Silverwood", "Goldholme", "Thornreach", "Emberglade",
                "Dragonholme", "Blackvale", "Windholme", "Moonreach", "Snowholme", "Amberreach"
            };
            List<string> towns = new List<string>();

            while (townCount < maxTowns)
            {
                int townNameSelector = random.Next(0, townNames.Count);

                towns.Add(townNames.ElementAt(townNameSelector));
                townNames.RemoveAt(townNameSelector);

                townCount++;
            }
            // Town Prints

            /*
            for (int i = 0; i < towns.Count; i++)
            {
                Console.WriteLine(towns[i]);
            }
            Console.ReadKey();
            */
        }
    }
}
