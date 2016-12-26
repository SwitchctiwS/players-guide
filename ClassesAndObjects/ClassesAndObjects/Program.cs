using System;

namespace ClassesAndObjects
{
	class MainClass
	{
		public static void Main (string[] args)
		{
            bool exitCondition = false;
            int userChoice;
            int dieRoll;
            int sum;
            string exit;
            Random random = new Random();

            do
            {
                sum = 0;
                exit = null;

                Console.WriteLine("How many die do you want to roll?");
                userChoice = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < userChoice; i++)
                {
                    dieRoll = random.Next(6) + 1;
                    sum += dieRoll;
                    Console.WriteLine($"Roll {i + 1} is {dieRoll}");
                }

                Console.WriteLine($"The sum was: {sum}");
                Console.WriteLine("Type \"exit\" or \"quit\" to leave program.");

                exit = Console.ReadLine();
                if (exit == "exit" || exit == "quit")
                    exitCondition = true;

            } while (exitCondition == false);
		}
	}
}
