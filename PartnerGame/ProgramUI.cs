using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PartnerGame
{
    public class ProgramUI
    {
        Resources resources = new Resources();

        public void Run()
        {
            GameTitle();
            StartMenu();
        }
        public static void GameTitle()
        {
            Console.Clear();
            Blue("Welcome to The Math Caverns!\n\nGood luck!\n");
            Console.WriteLine("Press Enter to begin");
            Console.ReadLine();
            Console.Clear();
        }
        
        public static void StartMenu()
        {
            Console.Clear();
            
            Blue("Name your character\n");
            
            string name = Console.ReadLine();
            Background("Choose your title,\n1. The Wise\n2. The Conqueror\n3. The Ubiquitous\n4. The Charming\n5. The Aloof");
            string title = Console.ReadLine();
            switch (title)
            {
                case "1":

                    Magenta($"I hope you brought your calculator, {name}" + CharacterTitle.TheWise);

                    break;
                case "2":

                    Red($"I hope you brought your calculator, {name}" + CharacterTitle.TheConqueror);

                    break;
                case "3":

                    Green($"I hope you brought your calculator, {name}" + CharacterTitle.TheUbiquitous);

                    break;
                case "4":

                    Blue($"I hope you brought your calculator, {name}" + CharacterTitle.TheCharming);

                    break;
                case "5":

                    Background($"I hope you brought your calculator, {name}" + CharacterTitle.TheAloof);

                    break;
                default:

                    Console.WriteLine($"Your following-directions skill-set leaves a lot to be desired, {name}" + CharacterTitle.TheUndecided + " I hope you brought your calculator.");

                    break;
            }
            Console.ReadKey();
            Console.Clear();
            FirstLevel();


        }
        public static void FirstLevel()
        {
            Resources.Window();
            Console.Clear();
            
            Console.WriteLine("Welcome adventurer to the first room in the math cavern.");
            Thread.Sleep(500);
            Console.WriteLine("The cavern is dark and wet. On the far side of the room there is a light\n illuminating some writing scratched into the wall");
            Thread.Sleep(500);
            Console.WriteLine("You walk up to the wall and read what it says:");
            Thread.Sleep(500);
            Console.WriteLine(" X + 3 = 9   X = __");
            Thread.Sleep(500);
            Console.WriteLine("There is a pencil below will you fill in the answer? y or n");
            string choice = Console.ReadLine().ToLower();

            if (choice == "y")
            {
                Console.WriteLine("What is the answer? Answer with a single numerical value");
                string answer = Console.ReadLine();
                if (answer == "6")
                {
                    Console.WriteLine("You hear a loud noise and a passage leading to the next level has appeared");
                    Console.ReadKey();
                    SecondLevel();
                }
                else
                    Console.WriteLine("That's not quite right... a rock fell and you died.");
                Console.ReadKey();
                GameTitle();

            }
            else
                Console.WriteLine("Why don't you sit on a rock and think about it for an hour.\nHit any key once you've rethought your choices and want to try again");
            Console.ReadKey();
            Console.Clear();
            FirstLevel();

        }




        public static void SecondLevel()
        {
            Resources.Window();
            Console.Clear();
            Background("You enter the passageway to the second room and enter a hallway.\n");
            Thread.Sleep(500);
            Background("There are lit torches leading the way down the hall");
            Thread.Sleep(500);
            Background("As you walk down the hall you wonder to yourself,");
            Thread.Sleep(500);
            Background("how do you keep these torches lit in a sealed cave?");
            Thread.Sleep(500);
            Background("Alas, that is a mystery for a another time and another game.");
            Thread.Sleep(500);
            Background("The Hallway opens up to a large cavern. There is a Roman Temple in the\n middle of the cavern.");
            Thread.Sleep(500);
            Background("You walk between the pillars to the center of the temple and see stone buttons\n and an inscription.");
            Thread.Sleep(500);
            Background("It reads: VI + X = ???"); 
            Thread.Sleep(500);
            Background("Below are three buttons that are labeled I, V, and X.");

            Console.WriteLine("Type in the three symbols in the correct order to pass this challenge.");
            string numerals = Console.ReadLine().ToLower();
            if (numerals == "xvi")
            {
                Console.WriteLine("You have chosen wisely.");
                Console.WriteLine("Press any key to proceed in your journey.");
                Console.ReadKey();
                Console.Clear();
                ThirdLevel();
            }
            else
            {
                Console.WriteLine("That was the wrong answer. You feel something hit the back of your head. You wake up and your eyes gaze upon a familiar room.");
                Console.WriteLine("Hit any key to proceed.");
                Console.ReadKey();
                Console.Clear();
                FirstLevel();
            }

        }


        public static void ThirdLevel()
        {
            Resources.Window();
            
            Blue("Congratulations, you've made it to the Geometrick Room!");
            Thread.Sleep(500);
            Green("There are 6 candles lighting the walls.");
            Thread.Sleep(500);
            Blue("A bat hangs from the ceiling.");
            Thread.Sleep(500);
            Green("This room is a regular hexagon.");
            Thread.Sleep(500);
            Blue("What is the measurement of each interior angle?");
            Thread.Sleep(500);
            Console.WriteLine("a. 90 degrees\nb. 120 degrees\nc. 150 degrees\nd. -3000 degrees");
            string answerThree = Console.ReadLine().ToLower();

            switch (answerThree)
            {
                case "a":
                    Red("The bat transforms into a vampire and says, 'GeomeTRY again' \nbefore biting you!");
                    Thread.Sleep(500);
                    FirstLevel();
                    break;

                case "b":
                    Green("A rope ladder falls through a hole in the ceiling for \nyou to climb into the next chamber.");
                    Console.ReadKey();
                    FourthLevel();
                    break;

                case "c":
                    Magenta("On one wall a message appears. 'You've been hexed'. \nThe wall crashes down and kills you.");
                    Thread.Sleep(500);
                    FirstLevel();
                    break;

                default:
                    Blue("That doesn't make any sense.  You should start over and \ngrab a math book before you enter.");
                    Thread.Sleep(500);
                    StartMenu();
                    break;
            }

        }

        public static void FourthLevel()
        {
            Console.Clear();
            Resources.Window();
            Resources.Music3();
            Console.WriteLine("As you walk into the next room you can hear the faint sound of music.");
            Console.WriteLine("And you half expect to see a red-hatted plumber lurking nearby.");
            
            Console.WriteLine("In the corner of the room there are three display cases.");
            Console.WriteLine("The first one contains two rubber duckys and is inscribed 14.");
            Console.WriteLine("The second one contains 2 containers of playdough and is inscribed 20.");
            Console.WriteLine("The last display case has a Ducky and a Container of Playdough in it.\nThe inscription is blank");
            Console.WriteLine("What # do you want to write into the space?");
            string answer4;
            answer4 = Console.ReadLine();
            if (answer4 == "17")
            {
                Console.WriteLine("You've solved the puzzle correctly again!");
                Console.WriteLine("You may Proceed... a dark doorway opens up.");
                Console.ReadKey();
                FifthLevel();
            }
            else
                Console.WriteLine("You have chosen incorrectly.");
            StartMenu();
        }

        public static void FifthLevel()
        {
            Console.Clear();
            Resources.Window();
            Console.WriteLine("You enter a pitch black room and hear nothing but a deep hum in the darkness.");
            Thread.Sleep(500);
            Console.WriteLine("The air is stale and when you step forward it sounds as if bones are being\n crushed under your feet.");
            Thread.Sleep(500);
            Console.WriteLine("Suddenly, a child's voice rings out, 'Hey, dummy. I'm surprised you've made\n it this far.'");
            Thread.Sleep(500);
            Console.WriteLine("You take a few deep breaths to calm your nerves, before shouting,\n 'What is this place?'");
            Thread.Sleep(500);
            Console.WriteLine("'There's one last riddle for you, my little hobbit,'\n says the boy from who knows where.");
            Thread.Sleep(500);
            Console.WriteLine("'What is the square root of 5041?'");
            Thread.Sleep(500);

            string finalAnswer = Console.ReadLine();

            if (finalAnswer == "71")
            {
                Console.WriteLine("Light breaks through from a crack in a door up ahead and you sprint over\n the bones to open it.");
                Console.ReadKey();
                YouWin();
            }
            else
            {
                Console.WriteLine("You are forced to listen to a child call you a dummy for the next 10 seconds\n before waking up in a familiar room.");
                for (int i = 1; i < 10; i++)
                {
                    Console.WriteLine("You dummy!");
                    Thread.Sleep(1000);
                }
                GameOver();
            }


        }
        static void Blue(string message)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        static void Green(string message)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(message);
            Console.ResetColor();
        }
        static void Red(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }
        static void Magenta(string message)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        static void Background(string message)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(message);
            Console.ResetColor();
        }


        public static void GameOver()
        {

            Console.Clear();
            Resources.Music2();
            Console.WriteLine("You have failed. Would you like to try this room again or start over?");
            Magenta("Spell out the number 11 if you want to return to this room.");

            string response = Console.ReadLine().ToLower();

            if (response == "eleven")
            {
                FifthLevel();
            }
            else
            {
                StartMenu();
            }
        }

        public static void YouWin()
        {
            Console.Clear();
            Resources.Typewrite("Congratulations, you win! You're a Mathematician!");
            Resources.Music();
            StartMenu();

        }
    }
}
