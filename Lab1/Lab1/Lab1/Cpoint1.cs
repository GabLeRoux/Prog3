using System;

namespace Lab1
{
	public class Cpoint1
	{
		private Vector2d coordonnes;

		public Cpoint1 (Vector2d point){
			coordonnes = point;
		}

		public void deplace(Vector2d nouveauPoint){
			coordonnes = nouveauPoint;
		}

		public void affiche(){
			Console.WriteLine("les coordonnées sont: " + coordonnes.x + "," + coordonnes.y);
		}
	}
}

