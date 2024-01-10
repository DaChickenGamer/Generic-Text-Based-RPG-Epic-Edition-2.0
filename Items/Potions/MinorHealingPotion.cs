using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Text_Based_RPG_Epic_Edition_2._0.Items
{
    public class MinorHealingPotion : PotionBase
    {
        public override int ItemID { get; set; } = 2;

        public override string Name { get; set; } = "Basic Sword";

        public override float TurnDuration { get; set; } = 0;

        public override void PotionFunction()
        {
            Program.CurrentPlayer.health += 5;
        }
    }
}
