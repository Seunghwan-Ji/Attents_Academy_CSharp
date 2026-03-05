using System;
using System.Runtime.CompilerServices;


namespace Monster
{
	abstract class Monster
	{
		protected string _name; // 이름
		protected int _health;    // 생명력
		protected int _defense;   // 방어력
		protected int _attack;    // 공격력

		public int defense
		{
			get => _defense;
		}

		public string Name
		{
			get => _name;
		}

		public int Health
		{
			get => _health;
			set => _health = value;
		}

		public Monster(string name, int health, int defense, int attack)
		{
			_name = name;
			_health = health;
			_defense = defense;
			_attack = attack;
		}

		public abstract void GetDamage(int attack);	// 추상 메소드

		public void Attack(Monster enemy)
		{
			Console.WriteLine($"Attack(Monster)");
			int oldHealth = enemy.Health;

			enemy.GetDamage(_attack); // GetDamage 메소드가 가상메소드여서 들어온 타입에 준해서 호출됩니다.

			Console.WriteLine($"{_name}이 {enemy.Name}을 공격해서 {oldHealth}의 생명력을 {enemy.Health}로 줄임");
		}

		// Monster 타입을 인자로 받는 Attack 메소드에서 Goblin, Slime의 GetDamage 메소드 호출되도록 하세요.



		public void Defense()
		{
			Console.WriteLine($"{_name}이 방어합니다.");
		}

		public void Run()
		{
			Console.WriteLine($"{_name}이 뜁니다.");
		}

		public void Info()
		{
			Console.WriteLine($"이름: {_name}\n생명력: {_health}\n방어력: {_defense}\n공격력: {_attack}\n");
		}
	}
}
