using System;

namespace Lab3{
	public class WhiteWizard : Wizard{
		public WhiteWizard (string name) : base (name){
			this.color = "white";
			UsedWeapon = new Staff (-50); // negative so the attack give point to target
		}

		public override void dealAttack (Character other)
		{
			if (other.GetType().ToString() == "Lab3.BlackWizard") {
				Console.Write (other.name + " has attacked " + this.name + " and ");
				this.Die ();
			} else {
				this.dealAttack (other);
			}
		}
	}
}

