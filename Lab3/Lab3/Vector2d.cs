using System;

namespace Lab3
{
	public class Vector2d
	{
		public int X{ get; set;}
		public int Y{ get; set;}

		public Vector2d (int X, int Y){
			this.X = X;
			this.Y = Y;
		}

		public void Add(Vector2d move){
			this.X += move.X;
			this.Y += move.Y;
		}
	}
}

