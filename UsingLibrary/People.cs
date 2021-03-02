using System;
using System.Collections.Generic; //Почему бы не удалить не используемые using 
using System.Text;

namespace UsingLibrary
{
	public partial class People : BaseObject
	{
		protected string _name;//protected -> private
		protected int _age; //Мы можем сделать поля приватными?

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

		public People(double mass, string name, int age) : base(mass) //Почему бы не проверить входные данные на null?
		{
			_name = name;
			/*
			 Например, так:
			 if (name == null) throw new ArgumentNullException("Имя не может быть null");
			 */

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