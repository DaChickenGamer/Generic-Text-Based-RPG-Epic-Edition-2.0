using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Text_Based_RPG_Epic_Edition_2._0.Items
{
    public abstract class WeaponBase : Item
    {
        public override ItemTypes ItemType { get; set; } = ItemTypes.Weapon;
        public abstract int Damage {get; set;}
    }
}
