using System;


namespace Monster
{
	internal class Goblin : Monster
	{
		private int _fireAttackRegist; // 화염 공격 저항력


		public int FireAttackRegist
		{
			get => _fireAttackRegist;			
		}

		public Goblin(string name, int health, int defense, int attack, int fireRegistAttack)
			: base(name, health, defense, attack)
		{

			_fireAttackRegist = fireRegistAttack;
		}

		public override void GetDamage(int attack)
		{
			Console.WriteLine($"Goblin.GetDamage()");
			int damage = attack - (_defense + _fireAttackRegist);

			if(damage <= 0)
			{
				damage = 0;
			}

			_health -= damage;
		}

	}
}
