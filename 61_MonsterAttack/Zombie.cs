
namespace Monster
{
	internal class Zombie : Monster
	{
		public Zombie(string name, int health, int defense, int attack) 
			: base(name, health, defense, attack)
		{
		}


		public override void GetDamage(int attack)  // 가상 메소드
		{
			Console.WriteLine($"Zombie.GetDamage()");
			int damage = attack - _defense;

			if (damage <= 0)
			{
				damage = 0;
			}

			_health -= damage;
		}

	}
}
