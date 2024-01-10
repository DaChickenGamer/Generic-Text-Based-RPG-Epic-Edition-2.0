using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Text_Based_RPG_Epic_Edition_2._0.Items
{
    public abstract class Item
    {
        public enum ItemTypes
        {
            Weapon,
            Armor,
            Potion,
            Tool
        }

        public abstract int ItemID { get; set; }
        public abstract ItemTypes ItemType { get; set; }
        public abstract string Name { get; set; }

    }
}
