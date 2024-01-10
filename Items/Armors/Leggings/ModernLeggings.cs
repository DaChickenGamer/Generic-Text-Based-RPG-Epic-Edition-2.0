using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Text_Based_RPG_Epic_Edition_2._0.Items.Armors.Leggings
{
    public class ModernLeggings : LeggingsBase
    {
        public override int ItemID { get; set; } = 4;
        public override string Name { get; set; } = "Jeans";
        public override int Defense { get; set; } = 1;
        public override int Health { get; set; } = 0;
    }
}
