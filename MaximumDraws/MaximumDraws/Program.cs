using System;

namespace MaximumDraws
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int testCases = Int32.Parse (Console.ReadLine ()); // Number of test cases
			for (int i = 0; i < testCases; i++)
			{
				int pairOfSocks = Int32.Parse (Console.ReadLine ()); // Convert input to string
				Console.WriteLine($"{pairOfSocks + 1}");
			}
		}
	}
}
