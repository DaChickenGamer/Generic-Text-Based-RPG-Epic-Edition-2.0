using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Generic_Text_Based_RPG_Epic_Edition_2._0.Items;
using Generic_Text_Based_RPG_Epic_Edition_2._0.Items.Weapons;
using Generic_Text_Based_RPG_Epic_Edition_2._0.Items.Armors.Helmet;
using Generic_Text_Based_RPG_Epic_Edition_2._0.Items.Armors.Chestplate;
using Generic_Text_Based_RPG_Epic_Edition_2._0.Items.Armors.Leggings;

namespace Generic_Text_Based_RPG_Epic_Edition_2._0
{
    internal class ItemDatabase
    {
        public List<Item> itemDatabase = new List<Item>
        {
            new BasicSword(),
            new ModernHat(),
            new ModernTShirt(),
            new ModernLeggings(),
            new MinorHealingPotion(),
        };
    }
}
