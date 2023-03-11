using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Text_Based_RPG_Epic_Edition_2._0.Enemies
{
    public abstract class Enemy
    {
        public abstract int EnemyID { get; set; }
        public abstract string Name { get; set; }
        public abstract int Health { get; set; }
        public abstract int Damage { get; set; }
        public abstract int CoinDrop { get; set; }
        public static Random Rand { get; set; } = new Random();

        public abstract void StartBattle();
        public abstract void PreBattle();
        public abstract void PostBattle();
        public void EnemyDeath()
        {
            if (Health >= 0)
            {
                Console.WriteLine("You defeated a " + Name);
                Player player = new Player();
                player.coins += CoinDrop;
            }
        }
    }
}
