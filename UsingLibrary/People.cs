using System;

namespace UsingLibrary
{
	public partial class People : BaseObject
	{
		protected string _name;
		protected int _age;

		public string Name
		{
			get
			{
				return _name;
			}
		}
		public int Age
		{
			get
			{
				return _age;
			}
		}

		public People(double mass, string name, int age) : base(mass)
		{
			_name = name ?? throw new ArgumentNullException("Name не может быть null");

			if (age < 0)
				throw new ArgumentOutOfRangeException("Возраст не может быть отрицательным числом!");
			_age = age;
		}

		public override string ToString()
		{
			return $"Имя: {Name}, возраст: {Age}, вес: {Mass}";
		}
	}
}