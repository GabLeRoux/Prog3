using System;

namespace Lab1
{
	public class Cpoint3
	{
		private Vector2d coordonnes;

		public Cpoint3 (Vector2d point){
			coordonnes = point;
		}

		public void deplace(Vector2d nouveauPoint){
			coordonnes = nouveauPoint;
		}

		public string affiche(){
			return ("les coordonnées sont: " + coordonnes.x + "," + coordonnes.y);
		}
	}
}

