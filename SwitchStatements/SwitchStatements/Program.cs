using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int menuChoice = 3;

            //types allowed: string, bool, any integral types, and enums
            switch (menuChoice)
            {
                case 1:
                    Console.WriteLine("You chose option #1");
                    break;
                case 2:
                    Console.WriteLine("You chose option #2. I like that one too!");
                    break;
                case 3:
                    Console.WriteLine("I can't believe you chose option #3.");
                    break;
                case 4:
                    Console.WriteLine("You can do better than 4....");
                    break;
                case 5:
                    Console.WriteLine("5? Really? That's what you went with?");
                    break;
                default:
                    Console.WriteLine("Hey! That wasn't even an option!");
                    break;

                    // The flow of execution will only go to ONE case label. More than one case will never be executed.
                    // Every case block needs a break statement, unlike C++ or Java
                    // However, two cases can be stacked on top of each other, indicated that they are the same thing:

                    // case 1:
                    // case 2:
                    //     ...code...
                    //      break;

            }
            */



            // Simple Calculator
            double a; // User's first input
            double b; // User's second input
            double result = double.NaN; // Final output
            char operation; // The inputted mathematical operation to perform

            // Get user inputs
            Console.WriteLine("Please enter the first number:");
            a = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("\nPlease enter the second number:");
            b = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("\nPlease enter the mathematical operation:");
            operation = Convert.ToChar(Console.ReadLine());

            // Calculate the result from input
            switch (operation)
            {
                case ('+'):
                    result = a + b;
                    break;
                case ('-'):
                    result = a - b;
                    break;
                case ('*'):
                    result = a * b;
                    break;
                case ('/'):
                    result = a / b;
                    break;
                case ('%'):
                    result = a % b;
                    break;
                case ('^'):
                    result = Math.Pow(a, b);
                    break;
                default:
                    Console.WriteLine("That wasn't a valid operation.");
                    break;
            }

            // Output result
            Console.WriteLine($"The result is {result}.");
            Console.ReadKey();

        }

    }

}
