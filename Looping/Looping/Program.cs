using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Looping
{
    class Program
    {
        static void Main(string[] args)
        {
            // Test inputs
            int x = 0;
            int y = 0;

            // Intentional inifinte loop (Forever loop)
            while (true)
            {
                // Example code
                Console.WriteLine(x);

                x++;    // Leave out the rest for a real infinite loop
                if (x == 10)
                    break;  // Put a break statement to exit the loop (or any loop)
                            // In this case, numbers 0 to 9 would be printed
            }

            Console.ReadKey(); // Press key to exit
            Console.WriteLine();

            do
            {
                y++;

                if (y == 4)
                    continue;   // The continue keyword goes back to the beginning of the loop 
                                // and retests the condition, without executing the rest of the loop
                                // In this case, numbers 1 to 10 would be printed EXCEPT 4

                Console.WriteLine(y);
            } while (y < 10);

            Console.ReadKey();  // Press to exit
            Console.WriteLine();


            // Make a pyramid
            for (int row = 0; row < 5; row++)
            {
                for (int numOfSpaces = 5; numOfSpaces - row - 1> 0; numOfSpaces--)
                    Console.Write(" ");

                for (int numbOfAsters = 0; numbOfAsters - 1 < row * 2; numbOfAsters++)
                    Console.Write("*");

                Console.WriteLine();
            }

            Console.ReadKey();
            Console.WriteLine();

            // FizzBuzz problem
            // Print numbers 1 to 100
            // if the number is a multiple of 3, print out "Fizz"
            // if the number is a multiple of 5, print out "Buzz"
            // if the number is a multiple of 3 and 5, print out "FizzBuzz"
            int i;  // Index

            for (i = 1; i < 100 + 1; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                    Console.WriteLine("FizzBuzz");
                else if (i % 3 == 0)
                    Console.WriteLine("Fizz");
                else if (i % 5 == 0)
                    Console.WriteLine("Buzz");
                else
                    Console.WriteLine(i);
            }
            Console.ReadKey();
            Console.WriteLine();
        }
    }
}
