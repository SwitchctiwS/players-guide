using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrefixAndPostfixIncrementing
{
    class Program
    {
        static void Main(string[] args)
        {
            // a++ means give me the value in a, then increment a, while ++a means increment a first, then give me the resulting value.

            // Prefix notation
            int a = 3;
            Console.WriteLine(a);
            int b = ++a;    // Both 'a' and 'b' will now be 4.
            Console.WriteLine($"{a}, {b}");

            // Above is the same as this:
            a = 3;
            Console.WriteLine(a);
            a++;
            b = a;
            Console.WriteLine($"{a}, {b}");


            // Postfix notation (more common)
            int c = 3;
            Console.WriteLine(c);
            int d = c++;    // The original value of 3 is assigned to 'd', while 'c' is now 4.
            Console.WriteLine($"{c}, {d}");

            // Above is the same as this:
            c = 3;
            Console.WriteLine(c);
            d = c;
            c++;    // This makes d increase by 1
            Console.WriteLine($"{c}, {d}");

            Console.ReadKey();
        }
    }
}
