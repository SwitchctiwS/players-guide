using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cylinder
{
    class Program
    {
        static void Main(string[] args)
        {
            float h, r, v, sa;
            const float pi = 3.14159F;

            //Get cylinder's height and radius from user
            Console.WriteLine("Enter the height of the cylinder:");
            h = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter the radius of the cylinder:");
            r = Convert.ToSingle(Console.ReadLine());

            //Calculate volume and surface area from user's inputs
            v = pi * r * r * h;
            sa = 2 * pi * r * (r + h);

            //Output V and SA
            Console.WriteLine("The volume is: " + v + "."); //Using concatecation (+)
            Console.WriteLine($"The surface area is: {sa}."); //Using string interpolation

            //Wait for user to press a key to proceed to next part
            Console.ReadKey();

            Console.WriteLine(@"This is a string literal. I put put as many escape characters as I want! \\\\\n\n\n\t\");
            Console.ReadKey();
        
        }
    }
}
