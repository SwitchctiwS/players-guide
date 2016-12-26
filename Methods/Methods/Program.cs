using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        // In C# a method can be placed ANYWHERE in a class. It can be before or after Main(). It doesn't matter.

        // If a method returns (void) there is no need for a return statement, otherwise it's required.
        // As soon as a return statement is hit, the flow of execution immediately goes back to where
        // the method was called from — nothing more gets executed in the method.

        // There’s a technical limit to how many
        // parameters you can have(just over 65,500) but the practical limit is far lower. Most programmers
        // will start complaining about the number of parameters a method has well before you even reach 10.

        // Reversing an array
        static void Main(string[] args)
        {
            int[] numbers = GenerateNumbers(); // Array of numbers to reverse
            Reverse(numbers);
            PrintNumbers(numbers);

            Console.WriteLine();
            Console.ReadKey();

            // Method Overload
            Console.WriteLine(Multiply(3, 4));
            Console.WriteLine(Multiply(4, 3, 6));
            Console.WriteLine(Multiply(4.3, 2.5));

            Console.WriteLine();
            Console.ReadKey();

            //Method Recursion
            Console.WriteLine("Please enter the amount of recursions.");
            int recursions = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Fibonacci(recursions));

            Console.WriteLine();
            Console.ReadKey();
        }

        static int[] GenerateNumbers()
        {
            int[] fwdNumbers = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            return fwdNumbers;
        }

        static void Reverse(int[] fwdNumbers)
        {
            int[] rvsNumbers = new int[fwdNumbers.Length];

            for (int i = 0; i < fwdNumbers.Length; i++)
                rvsNumbers[i] = fwdNumbers[fwdNumbers.Length - i - 1]; // Swaps numbers

            for (int i = 0; i < rvsNumbers.Length; i++) // NOTE: When you change a value in an array (e.g. fwdNumbers[0] = 3), 
                                                        // it saves to the ORIGINAL ARRAY (so numbers[0] in Main() will be 3).
                                                        // But if you change the whole array (e.g. fwdNumbers = rvsNumbers)
                                                        // it WILL NOT save to the original array!
                fwdNumbers[i] = rvsNumbers[i]; // Loop through, changing each variable
        }

        static void PrintNumbers(int[] rvsNumbers)
        {
            foreach (int number in rvsNumbers)
                Console.Write(number);
        }


        // Method Overloading
        // while two methods can have the same name, they can’t have the same signature. A
        // method’s signature is defined as the combination of the method name and the types and order of
        // the parameters that get passed in. Note that this does not include the parameters’ names, just their types.

        // These all work because their SIGNATURES are all different
        static int Multiply(int a, int b) // Signature: Multiply(int, int)
        {
            return a * b;
        }

        static int Multiply(int a, int b, int c)    // Signature: Multiply(int, int, int)
                                                    // i.e. Different amount of parameters
        {
            return a * b * c;
        }

        static double Multiply(double a, double b)  // Signature: Multiply(double, double)
                                                    // i.e. Different type of parameters
        {
            return a * b;
        }

        // The C# compiler can determine which one is the correct one to use.
        // The magic of method overloading is that you can have many methods that do very similar work on
        // different types of data (like the int multiplication and the double multiplication above) without
        // having to have a completely different method name.
        // Only use it when you are
        // trying to do the exact same kind of thing with different kinds of data. If two methods have the same
        // name, they should perform essentially the same task.


        // XML Comments (done with "///") 
        // Has auto-fill when typed above different things (like methods)

        /// <summary>
        /// This is what this method does.
        /// </summary>
        /// <param name="a">This is what parameter "a" is for.</param>
        /// <param name="b">This is what parameter "b" is for.</param>
        /// <returns>This is what the method returns.</returns>
        static string XMLComments(char a, char b)
        {
            string yee = "Something";
            return yee;
        }
        // When we do this, the stuff automatically appears in Visual Studio's Intellisense


        // Method Recusion
        // Fibonacci Sequence
        static int Fibonacci(int number)
        {
            // This is the "base condition".
            // i.e. the condition that will allow the recursions to stop.
            if (number == 2 || number == 1)
                return 1;

            return Fibonacci(number - 1) + Fibonacci(number - 2);
        }
    }
}
