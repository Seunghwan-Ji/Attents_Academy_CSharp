using System;
using System.Reflection.Metadata;


namespace Monster
{
	internal class Slime : Monster
	{

		private int _physicalAttackRegist; // 물리 공격 저항력


		public int PhysicalAttackRegist
		{
			get => _physicalAttackRegist;
		}

		public Slime(string name, int health, int defense, int attack, int physicalAttackRegist)
			: base(name, health, defense, attack)
		{
			_physicalAttackRegist = physicalAttackRegist;
		}

		public override void GetDamage(int attack)
		{
			Console.WriteLine($"Slime.GetDamage()");
			int damage = attack - (_defense + _physicalAttackRegist);

			if(damage <= 0)
			{
				damage = 0;
			}

			_health -= damage;

		}


	}
}
