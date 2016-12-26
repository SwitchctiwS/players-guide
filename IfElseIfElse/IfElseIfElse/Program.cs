using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElseIfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            int score;

            Console.Write("Enter your score: ");
            string scoreAsText = Console.ReadLine();
            score = Convert.ToInt32(scoreAsText);

            // This if-statement is separate from the rest of them. Not because of the blank
            // line between this statement and the next block, but because that starts all
            // over with a brand new if-statement.
            if (score == 100)
                Console.WriteLine("Perfect score! You win!");

            // This checks each condition in turn, until it finds the FIRST one that
            // is true, at which point, it executes the chosen code block, then jumps down
            // to after the end of the whole if/else code.
            if (score >= 90)
                Console.WriteLine("You got an A.");
            else if (score >= 80)
                Console.WriteLine("You got a B.");
            else if (score >= 70)
                Console.WriteLine("You got a C.");
            else if (score >= 60)
                Console.WriteLine("You got a D.");
            else
                Console.WriteLine("You got an F.");

            Console.ReadKey();

            // Finding out whether and int is even or odd
            int num;

            Console.WriteLine("Please enter a number:");
            num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
                Console.WriteLine($"The number {num} is even.");
            else
                Console.WriteLine($"The number {num} is odd.");

            Console.ReadKey();

            //"Lazy Evaulation"
            int shields = 50;
            int armor = 20;
            if (shields > 0 || armor > 0)
                Console.WriteLine("You're still alive! Keep going!");

            // One thing worth mentioning is that with either of these, the computer will do "lazy evaluation". This
            // means that it won’t check the second part unless it needs to. So in the example above, the computer
            // will always check to see if shields is greater than 0, but it only bothers checking if armor is greater
            // than 0 if shields is less than or equal to 0.
        }
    }
}
