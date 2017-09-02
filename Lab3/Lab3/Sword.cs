using System;

namespace Lab3{
	public class Sword : Weapon {

		public int length{ get; set;}

		public Sword(int Damage, int length) : base(Damage){
			this.length = length;
		}
	}
}

