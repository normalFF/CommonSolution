using System;
using System.Collections;
using UsingLibrary;

namespace ExampleEnumerable.IEnumerableObjects
{
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