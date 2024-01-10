using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Text_Based_RPG_Epic_Edition_2._0.Items
{
    public abstract class ArmorBase : Item
    {
        public enum ArmorTypes
        {
            Helmet,
            Chestplate,
            Leggings
        }
        public override ItemTypes ItemType { get; set; } = ItemTypes.Armor;
        public abstract ArmorTypes ArmorType { get; set; }
        public abstract int Defense {get; set;} // Based on % 
        public abstract int Health {get; set;} // Pure value
    }
}
