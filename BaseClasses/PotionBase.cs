using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Text_Based_RPG_Epic_Edition_2._0.Items
{
    public abstract class PotionBase : Item
    {
        public override ItemTypes ItemType { get; set; } = ItemTypes.Potion;
        public abstract float TurnDuration { get; set; }
        public abstract void PotionFunction();
    }
}
