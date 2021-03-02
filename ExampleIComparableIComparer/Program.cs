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

			Console.WriteLine("Сортировка по умолчанию:");
			Array.Sort(people);
			foreach (People p in people)
				Console.WriteLine(p.ToString());

			Console.WriteLine("\nОбратная сортировка по именам:");
			Array.Sort(people, People.sortNameDescending());
			foreach (People p in people)
				Console.WriteLine(p.ToString());

			Console.WriteLine("\nСортировка по именам:");
			Array.Sort(people, People.sortAgeAscending());//Судя по названию метода должен сортировать по возрасту)
			foreach (People p in people)
				Console.WriteLine(p.ToString());

			Array.Sort(people, People.sortAgeDescending());//не дошли еще руки дальше написать вывод текста пояснительного на косоль?))
			Console.WriteLine("\n");
			foreach (People p in people)
				Console.WriteLine(p.ToString());

			Array.Sort(people, People.sortMassAscending());
			Console.WriteLine("\n");
			foreach (People p in people)
				Console.WriteLine(p.ToString());

			Array.Sort(people, People.sortMassDescending());
			Console.WriteLine("\n");
			foreach (People p in people)
				Console.WriteLine(p.ToString());

			Console.ReadKey();
		}
	}
}
