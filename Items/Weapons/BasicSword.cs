using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Text_Based_RPG_Epic_Edition_2._0.Items.Weapons
{
    public class BasicSword : WeaponBase
    {
        public override int ItemID { get; set; } = 1;

        public override string Name { get; set; } = "Basic Sword";

        public override int Damage { get; set; } = 1;

    }
}
