using System;
using System.Collections;
using UsingLibrary;

namespace Task3.IEnumerableObjects
{
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
}