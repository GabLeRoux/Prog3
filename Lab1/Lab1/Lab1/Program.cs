using System;

namespace Lab1
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Cpoint1 Coordonne = new Cpoint3 (new Vector2d(0,0));
			Console.WriteLine ("entrez les coordonnées...\nx: ");
			double x = Convert.ToDouble(Console.ReadLine ());
			Console.WriteLine ("y: ");
			double y = Convert.ToDouble(Console.ReadLine ());
			Coordonne.deplace (new Vector2d(x, y));
			Console.WriteLine(Coordonne.affiche ());
			Console.ReadLine ();
		}
	}
}
