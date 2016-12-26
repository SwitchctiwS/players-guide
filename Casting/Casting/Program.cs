using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            //Number practice

            //Creating infinities
            double a = double.PositiveInfinity;
            float b = float.NegativeInfinity;

            Console.WriteLine($"Positive infinity {a}");
            Console.WriteLine($"Negative infinity {b}");

            //NaN (Not a Number)
            float c = float.NaN;
            double d = double.NaN;

            Console.WriteLine($"Not a number {c}");
            Console.WriteLine($"Also Not a Number {d}");

            //Using the Math class (but not "Math Class")
            Console.WriteLine($"Pi is approximately {Math.PI}.");
            Console.WriteLine($"E is approximately {Math.E}");

            //MinValues and MaxValues
            int e = int.MaxValue;
            double f = double.MinValue;
            Console.WriteLine($"Max int value is: {e}");
            Console.WriteLine($"Min double value is: {f}");

            //Implicit conversion from "narrorw" (i.e. float and int) to "wide" (double)
            double y = 1.0 + 1 + 1.0f;
            Console.WriteLine(y);

            //Explicit conversion from "wide" (float) to "narrow" (int)
            //Wide to narrow is always explicitly stated by casting
            int x = (int)(7 + (3.0 / 4.0) * 2);
            Console.WriteLine(x);

            Console.WriteLine((1 + 1) / 2 * 3);

            Console.ReadKey();
        }
    }
}
