using System;

namespace Lab3{
	public class Character{
		public Weapon UsedWeapon{ get; set;}

		protected Vector2d position;
		protected int health;

		public string name;

		public Character (string name){
			this.position = new Vector2d (0,0);
			this.health = 1000;
			this.name = name;
		}

		public virtual void AttackedBy(Character other){
			this.health -= other.UsedWeapon.Damage;
			Console.WriteLine (other.name + " did attack " + this.name + " and " + this.name + " now have " + this.health + " HP");
		}

		public void Move(Vector2d movement){
			this.position.Add (movement);
			Console.WriteLine (this.name + " has moved to " + this.position.X + "," + this.position.Y);
		}

		public void Die(){
			this.health = 0;
			Console.WriteLine (this.name + " has died!");
		}
	}
}

