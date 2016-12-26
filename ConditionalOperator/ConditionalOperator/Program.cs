using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            // '?' is the conditional operator
            // It is ternary (i.e. three parts)
            // It works like an if-else statement 

            // (boolean condition) ? value if true : value if false
            int score = 50;

            Console.WriteLine((score > 70) ? "You passed!" : "You failed.");
            Console.ReadKey();


        }
    }
}
