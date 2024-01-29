using System;
using Generic_Text_Based_RPG_Epic_Edition_2._0.Dialogue;
using Generic_Text_Based_RPG_Epic_Edition_2._0.Enemies;
using Generic_Text_Based_RPG_Epic_Edition_2._0.Towns;

namespace Generic_Text_Based_RPG_Epic_Edition_2._0
{
    internal class Program
    {
        public static Enemy CurrentEnemy { get; set; }
        public static Player CurrentPlayer { get; set; } = new Player();
        public static Inventory CurrentInventory { get; set; } = new Inventory();
        public static LandGeneration CurrentLandGeneration { get; set; } = new LandGeneration();
        static void Main(string[] args)
        {
            bool tutorial = Tutorial.tutorial;

            if (Tutorial.tutorial == false)
            {
                CurrentInventory.InitializeInventory();
                CurrentLandGeneration.WorldGeneration();
                Tutorial.Start();
            }
            else
            {
                FindingATown.Start();
            }
        }
    }
}
