using Monster;

namespace _202602251517_Polymorphism_MonsterAttack
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Monster.Monster monster = new  Monster.Monster("monster", 100, 25, 30); Monster클래스는 추상 클래스여서
																					 // 객체 생성안됩니다.

			Dragon dragonA = new Dragon("dragonA", 100, 25, 30);
			Dragon dragonB = new Dragon("dragonB", 100, 28, 27);

			Goblin goblinA = new Goblin("goblinA", 50, 10, 25, 8);
			Goblin goblinB = new Goblin("goblinB", 45, 10, 15, 8);

			Slime slimeA = new Slime("slimeA", 30, 8, 13, 7);

			Zombie zombieA = new Zombie("zombieA", 60, 13, 10);

			Golem golemA = new Golem("golemA", 80, 30, 20, 10);

			dragonA.Attack(dragonB);
			dragonB.Info();

			goblinA.Attack(goblinB);
			goblinB.Info();

			dragonA.Attack(goblinA);
			goblinA.Info();

			goblinB.Attack(dragonB);
			dragonB.Info();

			goblinA.Attack(slimeA);
			slimeA.Info();

			zombieA.Attack(goblinB);
			goblinB.Info();

			goblinB.Attack(zombieA);
			zombieA.Info();

			dragonA.Attack(golemA);
			golemA.Info();
		}
	}
}
