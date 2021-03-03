using System;
using System.Collections.Generic;
using UsingLibrary;
using ExampleIQueryable;
using Task3.IEnumerableObjects;

namespace ExampleIComparableIComparer
{
	class Program
	{
		static void Main(string[] args)
		{
			People[] people = ExampleIQueryable.Program.CreateCollective(7);

			Array.Sort(people);
			ConsoleInfo("Сортировка по умолчанию:", people);

			Array.Sort(people, People.sortNameDescending());
			ConsoleInfo("\nОбратная сортировка по именам:", people);

			Array.Sort(people, People.sortAgeAscending());
			ConsoleInfo("\nСортировка по возрасту:", people);

			Array.Sort(people, People.sortAgeDescending());
			ConsoleInfo("\nОбратная сортировка по возрасту:", people);

			Array.Sort(people, People.sortMassAscending());
			ConsoleInfo("\nСортировка по весу:", people);

			Array.Sort(people, People.sortMassDescending());
			ConsoleInfo("\nОбратная сортировка по весу:", people);

			Console.ReadKey();
		}

		static void ConsoleInfo(string s, in People[] people)
		{
			Console.WriteLine(s);
			foreach (People p in people)
				Console.WriteLine(p.ToString());
		}
	}
}