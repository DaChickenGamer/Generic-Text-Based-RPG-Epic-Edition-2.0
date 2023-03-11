using Generic_Text_Based_RPG_Epic_Edition_2._0.Dialogue;
using Generic_Text_Based_RPG_Epic_Edition_2._0.Enemies;

namespace Generic_Text_Based_RPG_Epic_Edition_2._0
{
    internal class Program
    {
        public static Enemy CurrentEnemy { get; set; }
        public static Player CurrentPlayer { get; set; }
        static void Main(string[] args)
        {
            bool tutorial = false;

            if (tutorial == false)
            {
                //Player
                Tutorial.Start();
            }
            /*else
            {
                Countinue();
            }*/
        }
    }
}
