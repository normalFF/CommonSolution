using System.Collections;
using UsingLibrary;

namespace ExampleEnumerable.IEnumerableObjects
{
	public class CollectivePeople : IEnumerable
	{
		private People[] _people;

		public CollectivePeople(People[] people)
		{
			_people = people;
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