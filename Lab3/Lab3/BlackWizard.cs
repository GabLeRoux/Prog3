using System;

namespace Lab3{
	public class BlackWizard : Wizard{
		public BlackWizard (string name) : base(name){
			this.color = "black";
			UsedWeapon = new Staff (50); 
		}
	}
}

