using System;
using System.Collections.Generic;
using Generic_Text_Based_RPG_Epic_Edition_2._0.Items;
using Generic_Text_Based_RPG_Epic_Edition_2._0;

namespace Generic_Text_Based_RPG_Epic_Edition_2._0
{

    internal class Player
    {
        public int MaxHealth { get; set; } = 100; // Base health is 100
        public int Health { get; set; } = 100; // Starts at 100
        public int Defense { get; set; } = 1;
        public int Coins { get; set; } = 0;
        public int Damage { get; set; } = 1;
        public double Multiplyer { get; set; } = 1.0;
        public int Level { get; set; } = 1;
        public int Experience { get; set; } = 0;
        public void HealthCheck()
        {
            if (Health <= MaxHealth)
                return;
            Health = MaxHealth;
        }
        public void Death()
        {
            if (Health <= 0)
            {
                Console.WriteLine("You died");
                Console.ReadKey();
            }
        }
        public void DisplayInfo()
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Current Level: " + Level);
            Console.WriteLine("Current Health: " + Health + "/" + MaxHealth);
            Console.WriteLine("Current Defense: " + Defense);
            Console.WriteLine("Current Damage: " + Damage + " Multiplyer: " + Multiplyer);
            Console.WriteLine("Coins: " + Coins);
            Console.WriteLine("---------------------------------");
        }
        private int _experienceToLevelUp = 100;
        // Come up with rewards for leveling up
        // I.E. stat points or increase to stats
        public void LevelUp()
        {
            if (Experience < _experienceToLevelUp) return;
            Level++;
            Experience = 0;
            MaxHealth += 10;
            Health = MaxHealth;
            _experienceToLevelUp = Convert.ToInt32(_experienceToLevelUp * .5f);
            Console.WriteLine("You leveled up!");
            Console.ReadKey();
        }
    }
}