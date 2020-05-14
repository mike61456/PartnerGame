using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartnerGame
{
    public class Levels
    {

        public static void Level1()
        {
            string choice = Console.ReadLine();
            if (choice == "y")
            {
                Console.WriteLine("What is the answer? Answer with a single numerical value");
                string answer = Console.ReadLine();
                if (answer == "6")
                {
                    Console.WriteLine("You hear a loud noise and a passage leading to the next level has appeared");
                    Console.ReadKey();
                    Level2();
                }
                else
                    Console.WriteLine("That's not quite right... a rock fell and you died.");
                Console.ReadKey();
                Level1();

            }
            else
                Console.WriteLine("Why don't you sit on a rock and think about it for an hour. Hit any key once you've rethought your choices and want to try again");
            Console.ReadKey();
            Level1();
        }
        public static void Level2() { 


        string numerals = Console.ReadLine().ToLower();
            if (numerals == "xvi")
            {
                Console.WriteLine("You have choosen wisely");
                Console.WriteLine("Press any key to proceed in your journey");
                Console.ReadKey();
                Level1();
    }
            else
            {
                Console.WriteLine("That was the wrong answer. You feel something hit the back of your head. You wake up and your eyes gaze upon a familiar room");
                Console.WriteLine("Hit any key to proceed");
                Console.ReadKey();
                Level1();
}
     }

    }
}
