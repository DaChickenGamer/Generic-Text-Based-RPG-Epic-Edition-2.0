using Generic_Text_Based_RPG_Epic_Edition_2._0.Dialogue;
using Generic_Text_Based_RPG_Epic_Edition_2._0.Enemies;

namespace Generic_Text_Based_RPG_Epic_Edition_2._0
{
    internal class Program
    {
        public static Enemy CurrentEnemy { get; set; }
        public static Player CurrentPlayer { get; set; } = new Player();
        public static Inventory CurrentInventory { get; set; } = new Inventory();
        static void Main(string[] args)
        {
            bool tutorial = Tutorial.tutorial;

            if (Tutorial.tutorial == false)
            {
                CurrentInventory.InitializeInventory();
                Tutorial.Start();
            }
            else
            {
                FindingATown.Start();
            }
        }
    }
}
