using System;

namespace Generic_Text_Based_RPG_Epic_Edition_2._0
{
    internal class Player
    {
    public int maxHealth { get; set; } = 100; // Base health is 100
    public int health { get; set; } = 100; // Starts at 100
    public int defense { get; set; } = 1;
    public int coins { get; set; } = 0;
    public int damage { get; set; } = 1;
    public double multiplyer { get; set; } = 1.0;
        public void Death()
        {
            if (health <= 0)
            {
                Console.WriteLine("You died");
                Console.ReadKey();
            }
        }
        public void DisplayInfo()
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Current Health: " + health + "/" + maxHealth);
            Console.WriteLine("Current Defense: " + defense);
            Console.WriteLine("Current Damage: " + damage + " Multiplyer: " + multiplyer);
            Console.WriteLine("Coins: " + coins);
            Console.WriteLine("---------------------------------");
        }
    }
}