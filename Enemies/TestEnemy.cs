using Generic_Text_Based_RPG_Epic_Edition_2._0.Dialogue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Text_Based_RPG_Epic_Edition_2._0.Enemies
{
    internal class TestEnemy : Enemy
    {
        public override int EnemyID { get; set; } = 1;
        public override string Name { get; set; } = "TestEnemy";
        public override int Health { get; set; } = 20;
        public override int Damage { get; set; } = 1;
        public override int CoinDrop { get; set; } = Rand.Next(3, 5);
        
        Encounters ecounters = new Encounters();
        public override void StartBattle()
        {
            PreBattle();
            ecounters.FightStats(this);
            PostBattle();
        }
        public override void PreBattle()
        {
            Console.WriteLine("A dummy suddenly appears infront of you!");
            DialogueSettings.Clear();
        }
        public override void PostBattle()
        {
            Console.WriteLine("You manage to break the dummy in half!");
            DialogueSettings.Clear();
        }
    }
}
