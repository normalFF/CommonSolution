using System;
using System.Collections;

namespace Task3
{
	class Program
	{
		static void Main(string[] args)
		{
			People[] people = new People[] { new People("Tom", 23), 
											new People("Sam", 25), 
											new People("Jack", 30), 
											new People("Chris", 26) };

			CollectivePeople collective = new CollectivePeople(people);
			foreach (People p in collective)
			{
				Console.WriteLine(p.ToString());
			}

			Console.WriteLine("\n");
			IEnumerator pers = people.GetEnumerator();

			while (pers.MoveNext())
			{
				People p = (People)pers.Current;
				Console.WriteLine(p.ToString());
			}

			Console.ReadKey();
		}
	}


	class People
	{
		private string _name;
		private int _age;
		
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

		public People(string Name, int Age)
		{
			_name = Name;
			_age = Age;
		}

		public override string ToString()
		{
			return $"Person name: {Name}, age: {Age}";
		}
	}

	class CollectivePeople : IEnumerable
	{
		private People[] _people;

		public CollectivePeople(People[] people)
		{
			_people = new People[people.Length];

			for (int i = 0; i < _people.Length; i++)
			{
				_people[i] = people[i];
			}
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		IEnumerator GetEnumerator()
		{
			return new EnumeratorPeople(_people);
		}
	}

	class EnumeratorPeople : IEnumerator
	{
		People[] _people;
		int _position = -1;
		object IEnumerator.Current
		{
			get
			{
				return Current;
			}
		}
		People Current
		{
			get
			{
				try
				{
					return _people[_position];
				}
				catch (IndexOutOfRangeException)
				{
					throw new InvalidCastException();
				}
			}
		}

		public EnumeratorPeople(People[] people)
		{
			_people = people;
		}

		public bool MoveNext()
		{
			_position++;
			return (_position < _people.Length);
		}

		public void Reset()
		{
			_position = -1;
		}
	}
}
