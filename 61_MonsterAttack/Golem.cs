using System;


namespace Monster
{
	internal class Golem :  Monster
	{
		private int _poisonAttackRegist;


		public Golem(string name, int health, int defense, int attack, int poisonAttackRegist) 
			: base(name, health, defense, attack)
		{
			_poisonAttackRegist = poisonAttackRegist;
		}

		public override void GetDamage(int attack)  // 가상 메소드
		{
			Console.WriteLine($"Golem.GetDamage()");
			int damage = attack - (_defense + _poisonAttackRegist);

			if (damage <= 0)
			{
				damage = 0;
			}

			_health -= damage;
		}

	}
}
