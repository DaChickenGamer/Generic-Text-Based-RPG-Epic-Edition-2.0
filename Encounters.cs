using Generic_Text_Based_RPG_Epic_Edition_2._0.Dialogue;
using Generic_Text_Based_RPG_Epic_Edition_2._0.Enemies;
using System;

namespace Generic_Text_Based_RPG_Epic_Edition_2._0
{
    internal class Encounters
    {
        //bool inFight = false;
        public Enemy CurrentEnemy;
        public Player CurrentPlayer;

        public void FightStats(Enemy enemy)
        {
           CurrentEnemy = enemy;
           if (enemy != null)
            {
                while (enemy.Health > 0)
                {
                    int currentMove = 1;
                    currentMove++;

                    Console.WriteLine("Current Move: " + currentMove);

                    DialogueSettings.showStats = false;
                    Console.WriteLine("--------------------------");
                    Console.WriteLine("Enemy Name: " + CurrentEnemy.Name);
                    Console.WriteLine("Enemy Health: " + CurrentEnemy.Health);
                    Console.WriteLine("--------------------------");

                    Console.WriteLine("\n(A)ttack | (B)lock | (H)eal"); // Block has a chance to give an extra move
                    Program.CurrentPlayer.DisplayInfo();
                    string Input = Console.ReadKey(true).Key.ToString().ToLower();
                    Console.Clear();

                    if (Input == "a")
                        Attack(CurrentEnemy);
                    else if (Input == "h")
                        Heal(CurrentEnemy);
                    else if (Input == "b")
                        Block(CurrentEnemy);
                    else
                    {
                        Console.WriteLine("Invalid Input");
                        DialogueSettings.Clear();
                    }

                    DialogueSettings.showStats = true;
                }
            }
        }
        public void Attack(Enemy enemy)
        {
            int damage = Program.CurrentPlayer.damage;
            int health = Program.CurrentPlayer.health;

            int enemyHealth = enemy.Health;

            Random random = new Random();
            int rand = random.Next(0,13);
            if (rand < 6) // Success both attack
            {
                Console.WriteLine("\nSuccess you hit the monster!");
                Console.WriteLine(damage + " damage dealt!\n");
                Console.WriteLine("The monster hit you for " + enemy.Damage + " damage!\n");
                enemy.Health = enemy.Health - damage;
                Program.CurrentPlayer.health = Program.CurrentPlayer.health - enemy.Damage;

            }
            else if (rand > 5 && rand < 11) // Success but enemy misses
            {
                Console.WriteLine("\nSuccess you hit the monster!");
                Console.WriteLine(damage + " damage dealt!\n");
                Console.WriteLine("Enemy Missed!\n");
                enemy.Health = enemy.Health - damage;
            }
            else if (rand == 11 || rand == 12) // Player misses but enemy attacks
            {
                Console.WriteLine("\nYou missed the monster!");
                Console.WriteLine("You were hit for " + enemy.Damage + "!\n");
                Program.CurrentPlayer.health = Program.CurrentPlayer.health - enemy.Damage;
            }
            else if (rand == 13)  // Both Miss
            {
                Console.WriteLine("\nBoth missed!\n");
            }
        }
        public void Heal(Enemy enemy)
        {
            int damage = Program.CurrentPlayer.damage;
            int health = Program.CurrentPlayer.health;

            Random random = new Random();
            int healAmount = 1;
            int rand = random.Next(0,8);
            if (rand < 5) // Enemy Misses
            {
                health += healAmount;
                Console.WriteLine("\nSuccess you healed " + healAmount + "!\n"); // Heal Success
            }
            else if (rand > 4 && rand < 7) // Enemy Hits and You Heal
            {
                Console.WriteLine("\nSuccess you healed " + healAmount + "!"); // Heal Success
                Console.WriteLine("The enemy managed to get a hit in for " + enemy.Damage + " damage!\n");
            }
            else if (rand == 7) // Enemy Misses && Fail to heal
            {
                Console.WriteLine("\nFailed to heal!"); // Heal Failed
                Console.WriteLine("Enemy Missed!\n"); // Enemy Missed
            }
            else if (rand == 8) // Enemy Hits and Fail to heal
            {
                Console.WriteLine("\nFailed to heal!"); // Heal Failed
                health = health - enemy.Damage;
                Console.WriteLine("Enemy hit you for " + enemy.Damage + " damage!\n");
            }
        }
        public void Block(Enemy enemy)
        {
            int damage = Program.CurrentPlayer.damage;
            int health = Program.CurrentPlayer.health;

            Random random = new Random();
            int rand = random.Next(0,2);
            if (rand == 1)
            {
                Console.WriteLine("\nBlocked!"); // Block Success
                enemy.Health = enemy.Health - damage;
                Console.WriteLine("You managed to get a hit in for " + damage + " damage!\n"); // Hit 
            }
            else if (rand == 2)
            {
                Console.WriteLine("\nBlock failed!"); // Block Failed
                health = health - enemy.Damage;
                Console.WriteLine("Enemy hit you for " + enemy.Damage + " damage!\n");
            }
        }
    }
}
