using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Text_Based_RPG_Epic_Edition_2._0.Dialogue
{
    internal class DialogueSettings
    {
        public static bool showStats { get; set; } = false;
        private static bool knowHeaven = false; // Decides the background
        public static void Clear()
        {
            Player player = new Player();
            if (showStats == true)
                player.DisplayInfo();
            Console.WriteLine("\n(PRESS ANY BUTTON TO COUNTINE)");
            Console.ReadKey();
            Console.Clear();
        }
        public static void GodColorChange()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("God: ");
            if (knowHeaven == true)
                Console.ForegroundColor = ConsoleColor.Black;
            else if (knowHeaven == false)
                Console.ForegroundColor = ConsoleColor.White;
        }
        public static void HeavenColorChange()
        {
            knowHeaven = true;
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor= ConsoleColor.Black;
        }
    }
}
