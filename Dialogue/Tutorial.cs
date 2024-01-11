using Generic_Text_Based_RPG_Epic_Edition_2._0.Enemies;
using System;

namespace Generic_Text_Based_RPG_Epic_Edition_2._0.Dialogue
{
    internal class Tutorial : DialogueSettings
    {
        public static bool statsUnlocked = false;
        public static bool tutorial = false;
        public static void Start()
        {
            BeginningQuestions();
        }
        internal static void BeginningQuestions()
        {
            // Stages
            bool metGod = false;
            bool meetingGodLoop = true;
            bool statsUnlocked = false;

            // No Repeat Dialogue
            bool choiceADone = false;
            bool choiceBDone = false;

            Console.WriteLine("Hello Young Traveler, what is your name?\n");
            Console.WriteLine("(Enter A Name)");
            Console.Write("Name: ");
            string name = Console.ReadLine();

            // Getting the player name
            if (name == "")
            {
                Console.WriteLine("\n???: Quite a name!");
                DialogueSettings.Clear();
                Console.WriteLine("You died in your world.");
            }
            else if (name == "raymond" || name == "Raymond")
            {
                Console.WriteLine("\nYou feel slightly more powerful!"); // Make it give a small boost
            }
            else if (name == "The True God")
            {
                Console.WriteLine("\nI see now you're the true god.");
                Console.WriteLine("Take my powers!");
            }
            else
            {
                Console.WriteLine("???: Hello! " + name + ".");
                DialogueSettings.Clear();
                Console.WriteLine("???: " + name + ", you died in your world.");

            }

            // Introduction
            DialogueSettings.Clear();
            while (meetingGodLoop == true)
            {
                Console.WriteLine("(A) Who are you? (B) Where are we? (C) Next\n");
                Console.Write("Choice: ");
                string godChocie = Console.ReadKey(true).Key.ToString().ToLower();
                DialogueSettings.Clear();
                if (godChocie == "a" && choiceADone == false)
                {
                    Console.WriteLine(name + ": Who are you?\n");
                    Console.WriteLine("???: I am the god of this world.");
                    metGod = true;
                    choiceADone = true;
                    DialogueSettings.Clear();
                }
                else if (godChocie == "b" && choiceBDone == false)
                {
                    Console.WriteLine(name + ": Where are we?\n");
                    Console.WriteLine("???: You are in my world, the afterlife.");
                    DialogueSettings.HeavenColorChange();
                    choiceBDone = true;
                    DialogueSettings.Clear();
                }
                else if ((godChocie == "b" && choiceBDone == true) || (godChocie == "a" && choiceBDone == true))
                {
                    if (metGod == true)
                    {
                        DialogueSettings.GodColorChange();
                        Console.WriteLine("You already asked that!");
                    }
                    else
                    {
                        Console.WriteLine("???: You already asked that!");
                        DialogueSettings.Clear();
                    }
                }
                else if (godChocie == "c")
                {
                    if (metGod == true)
                    {
                        DialogueSettings.GodColorChange();
                        Console.WriteLine("Enough of the boring questions!");
                        DialogueSettings.Clear();
                    }
                    else if (choiceBDone == false && choiceADone == false)
                    {
                        Console.WriteLine("???: No questions, great!");
                        DialogueSettings.Clear();
                    }
                    else
                    {
                        Console.WriteLine("??? Enough of the boring questions!");
                        DialogueSettings.Clear();
                    }
                    meetingGodLoop = false;
                }
                else
                {
                    Console.WriteLine("Invalid Input!");
                    DialogueSettings.Clear();
                }
            }
            StarterGuide(metGod);
        }
        internal static void StarterGuide(bool metGod)
        {
            Encounters encounters = new Encounters();
            Dummy dummy = new Dummy();
            if (metGod == true)
            {
                DialogueSettings.GodColorChange();
                Console.WriteLine("Here kid take this.");
                Console.WriteLine("*You feel a sudden buzzing in your body has you see something pop up in your vision*");
                DialogueSettings.showStats = true;
                DialogueSettings.Clear();
                DialogueSettings.GodColorChange();
                Console.WriteLine("This world is filled with monsters, you'll have to learn to defend yourself");
                DialogueSettings.Clear();
                DialogueSettings.GodColorChange();
                Console.WriteLine("Here fight this dummy here to learn how to fight.");
                DialogueSettings.Clear();
                dummy.StartBattle();
                DialogueSettings.GodColorChange();
                Console.WriteLine("You're finally done with the enemy, took you long enough!");
                DialogueSettings.Clear();
                if (Program.CurrentPlayer.Health == 100)
                {
                    DialogueSettings.GodColorChange();
                    Console.WriteLine("You really did that without taking any damage impressive.");
                    DialogueSettings.Clear();
                }
                else
                {
                    DialogueSettings.GodColorChange();
                    Console.WriteLine("Dang, you took a lot of damage. Here take this.");
                    DialogueSettings.Clear();
                    Console.WriteLine("*You feel warm feeling flow throughout your body*");
                    DialogueSettings.Clear();
                    DialogueSettings.GodColorChange();
                    Program.CurrentPlayer.Health = 100;
                    Console.WriteLine("I gave you some health back. If you do this bad out there you'll die");
                    DialogueSettings.Clear();
                }
                DialogueSettings.GodColorChange();
                Console.WriteLine("Now kid! Are you ready?");
                DialogueSettings.Clear();
                DialogueSettings.GodColorChange();
                Console.WriteLine("Well it doesn't matter. Good luck! You'll need it.");
                DialogueSettings.Clear();
                Console.WriteLine("*You suddenly wake up in the middle of a grassy field*");
                tutorial = true;
            }
            else
            {
                Console.WriteLine("???: Here kid take this.");
                Console.WriteLine("*You feel a sudden buzzing in your body has you see something pop up in your vision*");
                DialogueSettings.showStats = true;
                DialogueSettings.Clear();
                Console.WriteLine("???: This world is filled with monsters, you'll have to learn to defend yourself");
                DialogueSettings.Clear();
                Console.WriteLine("???: Here fight this dummy here to learn how to fight.");
                DialogueSettings.Clear();
                dummy.StartBattle();
                Console.WriteLine("???: You're finally done with the enemy, took you long enough!");
                DialogueSettings.Clear();
                if (Program.CurrentPlayer.Health == 100)
                {
                    Console.WriteLine("???: You really did that without taking any damage impressive.");
                    DialogueSettings.Clear();
                }
                else
                {
                    Console.WriteLine("???: Dang, you took a lot of damage. Here take this.");
                    DialogueSettings.Clear();
                    Console.WriteLine("*You feel warm feeling flow throughout your body*");
                    DialogueSettings.Clear();
                    Program.CurrentPlayer.Health = 100;
                    Console.WriteLine("???: I gave you some health back. If you do this bad out there you'll die");
                    DialogueSettings.Clear();
                }
                Console.WriteLine("???: Now kid! Are you ready?");
                DialogueSettings.Clear();
                Console.WriteLine("???: Well it doesn't matter. Good luck! You'll need it.");
                DialogueSettings.Clear();
                Console.WriteLine("*You suddenly wake up in the middle of a grassy field*");
                tutorial = true;
            }
            FindingATown.Start();
        }
    }
}
