using System;

namespace DesigningAndBuildingClasses
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			// Get input from user
			Console.WriteLine ("Please enter the ball's...");
			Console.WriteLine("Radius in CM:");
			float radiusInCM = float.Parse ((Console.ReadLine ()));

			Console.WriteLine ("RGB + alpha (Seperated by spaces):");
			string[] temp_stringArray = Console.ReadLine ().Split (' ');
			byte[] temp_byteArray = new byte[4];
			for (uint i = 0; i < temp_stringArray.Length; i++)
				temp_byteArray [i] = byte.Parse(temp_stringArray [i]);
			
			Console.WriteLine ("Type:");
			string type = Console.ReadLine();

			Console.WriteLine ("Maker:");
			string maker = Console.ReadLine();

			// Create new Colour and Ball from user inputs
			Colour colourOfBall = new Colour (temp_byteArray [0], temp_byteArray [1], temp_byteArray [2]);
			Ball baseball = new Ball(radiusInCM, colourOfBall, type, maker);

			// Writes what kinds of ball it is
			Console.WriteLine (baseball.Type ());

			// Changes colour of baseball
			Console.WriteLine ("Change red of ball.");
			byte value = byte.Parse (Console.ReadLine ());
			baseball.Colours.Red = value;
			Console.WriteLine($"Red value is: {baseball.Colours.Red}");

			// Creates new Ball, changes its colour
			Ball ball = new Ball () { RadiusInCM = 10, Colours = new Colour (255, 255, 255) }; // Object Initializer Syntax
			ball.Colours = new Colour (0, 0, 0, 0); // Changes colours from max to none
			Console.WriteLine($"Blue value is: {ball.Colours.Blue}");

			// Creates another Ball, changes its colour
			Ball newestBall = new Ball (100, new Colour (0, 0, 0, 0), "yee", "Confucious");
			newestBall.Colours.Red = 255;
			Console.WriteLine ($"Red value is: {newestBall.Colours.Red}");
			Console.WriteLine (newestBall.Type ());

		}
	}
}
