using System;
using System.Diagnostics;
using Generic_Text_Based_RPG_Epic_Edition_2._0.Items;

namespace Generic_Text_Based_RPG_Epic_Edition_2._0
{
    public class StatsUpdate
    {
        // Keep its own method, might add more to it later like damage from quest , items , and leveling
        public void AddDamage(WeaponBase weapon)
        {
            Program.CurrentPlayer.Damage += weapon.Damage;
        }
        public void AddHelmetStats(HelmetBase helmet)
        {
            Program.CurrentPlayer.Defense += helmet.Defense;
            Program.CurrentPlayer.MaxHealth += helmet.Health;
        }
        public void AddChestplateStats(ChestplateBase chestplate)
        {
            Program.CurrentPlayer.Defense += chestplate.Defense;
            Program.CurrentPlayer.MaxHealth += chestplate.Health;
        }
        public void AddLeggingsStats(LeggingsBase leggings)
        {
            Program.CurrentPlayer.Defense += leggings.Defense;
            Program.CurrentPlayer.MaxHealth += leggings.Health;
        }
        public void RemoveHelmetStats(HelmetBase helmet)
        {
            Program.CurrentPlayer.Defense -= helmet.Defense;
            Program.CurrentPlayer.MaxHealth -= helmet.Health;
        }
        public void RemoveChestplateStats(ChestplateBase chestplate)
        {
            Program.CurrentPlayer.Defense -= chestplate.Defense;
            Program.CurrentPlayer.MaxHealth -= chestplate.Health;
        }
        public void RemoveLeggingsStats(LeggingsBase leggings)
        {
            Program.CurrentPlayer.Defense -= leggings.Defense;
            Program.CurrentPlayer.MaxHealth -= leggings.Health;
        }
        public void RemoveDamage(WeaponBase weapon)
        {
            Program.CurrentPlayer.Damage -= weapon.Damage;
        }
    }
}