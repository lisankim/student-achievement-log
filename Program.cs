using student_achievement_log.Classes;
using System;

namespace student_achievement_log
{
    public class Program
    {
        static void Main(string[] args)
        {
            MenuSelection();
        }

        private static void MenuSelection()
        {

            hundredWaysToSayVeryGood hundredWays = new hundredWaysToSayVeryGood();

            Console.WriteLine("Hi! Welcome to your practice log! Please enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hey " + name + "! Were you able to practice today?");

            int menuSelection = 0;
            while (menuSelection != 2)
            {
                Console.WriteLine("Enter 1 if you answered \"YES! Let me tell you all about it! ");
                Console.WriteLine("Enter 2 if you said, \"No, I wasn't able to practice today and let me tell you why.");

                if (!int.TryParse(Console.ReadLine(), out menuSelection))
                {
                    Console.WriteLine("Invalid selection. Please enter numbers 1 or 2, only.");
                }

                else if (menuSelection == 1)
                {
                    Console.WriteLine("What pieces/exercises did you work on? What did you learn from them? Press Enter when you are done.");
                    string answer = Console.ReadLine();
                    hundredWays.MachineAuditFile($"{DateTime.Now} Today I practiced: {answer}");
                    string affirmation = hundredWays.GetRandomAffirmation();
                    Console.WriteLine(affirmation + "\n" + "Good Bye!");
                    break;

                }

                else if (menuSelection == 2)
                {
                    Console.WriteLine("Why weren't you able to practice today? Please explain.");
                    string answer = Console.ReadLine();
                    hundredWays.MachineAuditFile($"{DateTime.Now} Today I practiced: {answer}");
                    Console.WriteLine("Okay. Thanks for letting me know. Let's try again tomorrow!!!");

                }

            }
        }
    }
}
