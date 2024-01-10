using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Text_Based_RPG_Epic_Edition_2._0.Items.Armors.Helmet
{
    public class ModernTShirt : ChestplateBase
    {
        public override int ItemID { get; set; } = 5;
        public override string Name { get; set; } = "T-Shirt";
        public override int Defense { get; set; } = 1;
        public override int Health { get; set; } = 0;
    }
}
