using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // To declare an array:
            int[] array1;

            // To actually create an array:
            int[] array2 = new int[10];

            // In the first example, we had not yet assigned a value to the array variable. We had just declared it,
            // reserving a spot for it. In this second example, our array now exists and has room for 10 items in it.


            char[] name = new char[] { 'J', 'a', 'r', 'e', 'd' };   // Don't have to put length of array, but it's useful

            Console.WriteLine(name.Length); // Prints length of array


            // Copying an array
            char[] swag = new char[10] { 's', 'w', 'a', 'g', 's', 'w', 'a', 'g', 'g', 'y' };
            char[] gaws = new char[swag.Length];

            for (int i = 0; i < swag.Length; i++)
                gaws[i] = swag[i];

            Console.WriteLine(swag);
            Console.WriteLine(gaws);

            Console.ReadKey();
            Console.WriteLine();

            //NOTE: to duplicate an array, and have it so that when you change one array, the other array changes as well, do this:
            char[] yee = new char[] { 'y', 'e', 'e' };
            char[] yeeCopy = yee;

            Console.WriteLine(yee);
            Console.WriteLine(yeeCopy);

            Console.ReadKey();
            Console.WriteLine();

            // Now to change the copy which will also change the original:
            yeeCopy[2] = 'y';

            Console.WriteLine(yee);
            Console.WriteLine(yeeCopy);

            Console.ReadKey();
            Console.WriteLine();

            // Multi-Dimentional arrays (array of arrays, i.e. a matrix)
            // If each array in the matrix have the same length, it is called a "rectangular (or square) array"
            // If each array in the matrix has a different length, it is called a "jagged array"
            // NOTE: only rectangular arrays are multi-dimentional arrays. Jagged arrays are NOT.

            // Examples
            int[,] matrix = new int[2, 2]; // Rectangular array
            matrix[0, 0] = 1;
            matrix[0, 1] = 2;
            matrix[1, 0] = 3;
            matrix[1, 1] = 4;

            // Note: GetLength gives back the size of the multi-dimensional array for a specific index.
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int column = 0; column < matrix.GetLength(1); column++)
                {
                    Console.Write(matrix[row, column] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            int[][] matrix2 = new int[4][]; // Jagged array
            matrix2[0] = new int[2] { 1, 2 };
            matrix2[1] = new int[1] { 3 };
            matrix2[2] = new int[3] { 4, 5, 6 };
            matrix2[3] = new int[4] { 7, 8, 9, 10 };

            for (int row = 0; row < matrix.Length; row++)
            {
                for (int column = 0; column < matrix2[row].Length; column++)
                {
                    Console.Write(matrix2[row][column] + " "); // Each item in the row separated by spaces
                }
                Console.WriteLine(); // Rows separated by lines
            }

            Console.ReadKey();
            Console.WriteLine();


            // The foreach loop
            // To use a foreach loop, you use the foreach keyword with an array, specifying the name of the
            // variable to use inside of the loop:
            // NOTE: There is no way to know what index you're currently at (but it does go through sequencially).
            // NOTE2: foreach loops are slightly slower than normal for loops.
            int[] scores = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            foreach (int score in scores)
                Console.WriteLine("Someone had this score: " + score);

            Console.ReadKey();
            Console.WriteLine();

            // Totalling and averaging revisited
            byte[] numsToAverage = new byte[5] { 5, 3, 2, 7, 10 };
            float average = 0.00f;

            foreach (short num in numsToAverage)
                average += num;

            average /= numsToAverage.Length;
            Console.WriteLine(average);

            Console.ReadKey();
        }
    }
}
