using System;

namespace Lab3{
	public class Warrior : Character{

		public Warrior (string name) : base(name){
			this.UsedWeapon = new Sword (100, 50);
		}
	}
}

