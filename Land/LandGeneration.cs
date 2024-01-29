using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace Generic_Text_Based_RPG_Epic_Edition_2._0.Towns
{
    public class LandGeneration
    {
        private Random random = new Random();
        
        public Dictionary<int, Continent> continents = new Dictionary<int, Continent>();
        
        List<string> ContinentNamesList = new List<string>
        {
            "Eldoria", "Mystria", "Celestria", "Drakoria", "Aerion", "Lumina", "Terranova", "Aquaterra", "Ignisia", "Shadowmere",
            "Gaia Prime", "Aetheris", "Valoria", "Frostfell", "Ember Isle", "Zephyria", "Solstice Land", "Nebulae Haven", "Mirage Realm", "Thundoria",
            "Verdant Haven", "Sable Highlands", "Starhaven", "Volcanis", "Crescent Shores", "Evergreen Expanse", "Penumbral Plateau", "Coral Archipelago", "Crimson Peaks", "Nimbus Dominion",
            "Seraphic Strand", "Quasar Quay", "Lushlands", "Echoing Abyss", "Astral Tundra", "Citadel of Dreams", "Crimson Cascade", "Frostfire Foothills", "Ethereal Enclave", "Vortex Valley",
            "Enigma Isles", "Obsidian Outlands", "Duskwood Dominion", "Azure Highlands", "Solaris Sanctuary", "Celestial Caldera", "Umbra Uplands", "Harmony Haven", "Oceana Oracle", "Nebula Nexus",
            "Ember Embrace", "Whispering Wastes", "Solar Spire", "Radiant Ridge", "Abyssal Atoll", "Shrouded Summit", "Sunchaser Sands", "Iridescent Isles", "Polar Palace", "Thunderstorm Thicket",
            "Quicksilver Quagmire", "Halcyon Highlands", "Frostbite Fjord", "Zephyr Zenith", "Driftwood Dominion", "Starlight Strand", "Verdigris Vale", "Spiral Springs", "Elemental Expanse", "Mirage Mesa",
            "Volcanic Vortex", "Ethereal Echo", "Stormy Sanctuary", "Ebon Enigma", "Astral Abyss", "Velvet Vale", "Crimson Cove", "Mystic Marsh", "Starlit Savanna", "Obsidian Oasis", "Gilded Grove",
            "Twilight Thicket", "Aqua Aegis", "Solar Serenity", "Lunar Lagoon", "Boreal Bastion", "Ember Echo", "Tempest Tundra", "Celestial Chasm", "Crystal Canopy", "Radiant Ravine", "Mirage Monolith",
            "Nebula Nook", "Aetherial Asylum", "Verdant Vista", "Frostfall Foothills", "Solar Spires", "Enigmatic Expanse", "Thunderstruck Thicket", "Shrouded Shorelines"
        };

        public string GenerateRandomNames(Random random)
        {
            string[] prefixes = { "Eld", "Mystic", "Dragon", "Silver", "Shadow", "Celestial", "Frost", "Storm", "Ember", "Whispering", "Moonlit", "Serpent", "Crystal", "Iron", "Aetherial", "Enchanted", "Phoenix", "Starfall", "Lunar", "Lost" };
            string[] suffixes = { "oria", " Isles", "reach", "wood Forest", "lands", " Peaks", "holm", "watch Plains", " Wastes", " Sands", "lit Vale", "'s Spine", " Haven", "hold Citadel", "ial Enclave", "ted Glade", " Dominion", "fall Summit", " Harbor", " Realms" };

            string prefix = prefixes[random.Next(prefixes.Length)];
            string suffix = suffixes[random.Next(suffixes.Length)];

            return prefix + suffix;
        }
        
        public void GenerateContinents()
        {
            int totalContientCount;
            int continentCount = 0;
            
            totalContientCount = random.Next(4, 9);

            while (continentCount < totalContientCount)
            {
                Continent continent = new Continent();
                Random randomContient = new Random();
                int randomContientNum = randomContient.Next(0, ContinentNamesList.Count);
                continent.Name = ContinentNamesList[randomContientNum];
                continents.Add(continentCount, continent);
                GenerateRegions(continent);
                continentCount += 1;
            }
        }

        public void GenerateRegions(Continent continent)
        {
            int randomRegionCount = random.Next(3, 20);
            int regionCount = 0;
            
            continent.Regions = new List<Region>();

            while (regionCount < randomRegionCount)
            {
                Region region = new Region();
                region.Name = GenerateRandomNames(random);
                continent.Regions.Add(region);
                GenerateTowns(region);
                regionCount += 1;
            }
        }

        public void GenerateTowns(Region region)
        {
            int randomTownCount = random.Next(5, 50);
            int townCount = 0;
            
            region.Towns = new List<Town>();

            while (townCount < randomTownCount)
            {
                Town town = new Town();
                town.Name = GenerateRandomNames(random);
                region.Towns.Add(town);
                townCount += 1;
            } 
        }

        public void WorldGeneration()
        {
            GenerateContinents();
        }
    }

    public class Town
    {
        public string Name { get; set; }
    }

    public class Region
    {
        public string Name { get; set; }
        public List<Town> Towns { get; set; }
    }

    public class Continent
    {
        public string Name { get; set; }
        public List<Region> Regions { get; set; }
    }
}