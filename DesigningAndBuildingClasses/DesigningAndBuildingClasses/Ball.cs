using System;

namespace DesigningAndBuildingClasses
{
	public class Ball
	{
		private Colour colours;
		private float radiusInCM;
		private string type;
		private string maker;
		private uint throws = 0;

		public Ball()
		{
		}

		public Ball (float radiusInCM, Colour colour)
		{
			this.radiusInCM = radiusInCM;
			this.colours = colour;
		}

		public Ball (float radiusInCM, Colour colour, string type)
		{
			this.radiusInCM = radiusInCM;
			this.colours = colour;
			this.type = type;
		}

		public Ball (float radiusInCM, Colour colour, string type, string maker)
		{
			this.radiusInCM = radiusInCM;
			this.colours = colour;
			this.type = type;
			this.maker = maker;
		}

		// Properties
		public float RadiusInCM
		{
			get
			{
				return radiusInCM;
			}
			set
			{
				radiusInCM = value;
			}
		}

		public Colour Colours
		{
			get
			{
				return colours;
			}
			set
			{
				colours = value;
			}
		}

		// Methods
		public string Type ()
		{
			return $"This is a {colours.Grayscale} {this.type} ball made by {this.maker}";
		}

		public float Pop ()
		{
			return this.radiusInCM = 0f;
		}

		// Will not increment if the ball has been popped
		public void Throw()
		{
			if (this.radiusInCM > 0)
				this.throws++;
		}

		public uint NumOfThrows()
		{
			return this.throws;
		}
	}
}

