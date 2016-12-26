using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Create a program that implements operator overloading with a class that has 3D Vectors.
/// </summary>
namespace _3dVectors {
    class Program {
        static void Main(string[] args) {
            Vector a = new Vector(2, 3, 6);
            Vector b = new Vector(4, 5, 1);

            Vector result = a + b;
            Console.WriteLine(result.ToString());

            result = -result;
            Console.WriteLine(result.ToString());

            Console.WriteLine(result == a);

            Console.ReadKey();
        }
    }
}
