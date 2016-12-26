using System;

namespace DesigningAndBuildingClasses
{
	public class Colour
	{
		private byte red;
		private byte green;
		private byte blue;
		private byte alpha;

		public Colour (byte red, byte green, byte blue)
		{
			this.red = red;
			this.green = green;
			this.blue = blue;
			this.alpha = 255;
		}

		public Colour (byte red, byte green, byte blue, byte alpha)
		{
			this.red = red;
			this.green = green;
			this.blue = blue;
			this.alpha = alpha;
		}

		// Using properties
		public Colour Colours { get; set; }

		public byte Red { get; set; }

		public byte Green { get; set; }

		public byte Blue { get; set; }

		public byte Alpha { get; set; }

		public byte Grayscale
		{
			get
			{
				return (byte)((this.red + this.green + this.blue) / 3);
			}
		}
		/*
		// Using getters and setters
		public byte GetColour(string colour)
		{
			switch (colour)
			{
			case "Red":
				return this.red;
			case "Green":
				return this.green;
			case "Blue":
				return this.blue;
			case "Alpha":
				return this.alpha;
			default:
				ErrorMessage ();
				return 0;
			}
		}

		public void SetColour(string colour, byte value)
		{
			switch (colour)
			{
			case "Red":
				this.red = value;
				break;
			case "Green":
				this.green = value;
				break;
			case "Blue":
				this.blue = value;
				break;
			case "Alpha":
				this.alpha = value;
				break;
			default:
				ErrorMessage ();
				break;
			}
		}

		private void ErrorMessage()
		{
			Console.WriteLine ("Error: Incorrect input");
		}
		
		*/
	}
}

