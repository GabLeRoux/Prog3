using System;

namespace Lab1
{
	public class Cpoint2
	{
		private Vector2d coordonnes;

		public Cpoint2 (Vector2d point){
			coordonnes = point;
		}

		public void deplace(Vector2d nouveauPoint){
			coordonnes = nouveauPoint;
		}

		public void affiche(){
			return ("les coordonnées sont: " + coordonnes.x + "," + coordonnes.y);
		}
	}
}

