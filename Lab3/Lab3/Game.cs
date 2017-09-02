using System;
using System.Collections.Generic;

namespace Lab3{
	public class Game{
		private List<Character> Players;

		public Game (){
			Players = new List<Character> ();
			Players.Add (new Warrior("Bob (WARRIOR)"));
			Players.Add (new BlackWizard("Joe (BLACK WIZARD)"));
			Players.Add (new WhiteWizard("Doe (WHITE WIZARD)"));
			this.Play ();
		}

		private void Play(){
			Players [1].Move (new Vector2d(0,2));
			Players [0].Move (new Vector2d(1,0)); //move x++
			Players [0].Move (new Vector2d(1,0)); //
			Players [0].dealAttack (Players[2]);// white wizard heal warrior
			//tha fuck is going on in there!!!
			//Players [2].dealAttack (Players[0]);// warrior attack white wizard
			Players [2].dealAttack (Players[1]);// black wizard destroy white wizard
			Players [0].dealAttack (Players[1]);// black wizard attack warrior
			Console.ReadKey();
		}
	}
}

