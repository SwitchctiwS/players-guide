using System;

namespace ValueAndReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
			// A string is a reference type
			// It's "home" is on the  heap

			string hello = "Hello World";
			Console.WriteLine (hello);

			// An integer is a value type
			// It's home is wherever the variable is stored (either stack OR heap)

			int x = 3;
			Console.WriteLine (x);

			// An array is a reference type, but an integer is a value type
			// What about arrays of integers?
			// Value types stay with the variable, so since an array is a reference type,
			// the array is saved on the heap, and the elements (the ints) are ALSO
			// with the array on the heap
			int[] array = new int[]{ 5, 2, 0, 1, 3, 4 };
			Array.Sort(array);
			foreach (int i in array)
				Console.WriteLine(i);
        }
    }
}
