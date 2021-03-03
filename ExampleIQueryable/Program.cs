using System;
using System.Collections;
using System.Linq;
using UsingLibrary;

namespace ExampleIQueryable
{
	public class Program
	{
		public enum Names
		{
			Белла = 1,
			Валентин,
			Вадим,
			Борис,
			Галина,
			Дина,
			Джек,
			Глеб,
			Арина,
			Алан,
			Жанна,
			Захар,
			Иван,
			Егор,
			Лариса,
			Майя,
			Злата,
			Наум,
			Павел
		}

		static void Main(string[] args)
		{
			People[] collectivePeople = CreateCollective(100);

			var selected = collectivePeople.Where(testc => testc.Mass >= 58 && testc.Mass <= 60 && testc.Name.Length == 5).OrderBy(val => val.Age);
			ForeachItem(selected, "Отбор по массе от 58 до 60 и длине имени в 5 букв, сортировка по возрасту");

			Console.WriteLine();
			selected = collectivePeople.Where(u => u.Age > 26 && u.Age < 30).OrderBy(val => val.Name.Length);
			ForeachItem(selected, "Отбор по возрасту от 27 до 29, сортировка по длине имени");

			Console.ReadKey();
		}

		static void ForeachItem(IEnumerable array, string s)
		{
			Console.WriteLine(s);
			foreach (People p in array)
			{
				Console.WriteLine(p.ToString());
			}
		}

		public static People[] CreateCollective(int val)
		{
			Random rn = new Random();
			People[] collectivePeople = new People[val];

			for (int i = 0; i < collectivePeople.Length; i++)
			{
				collectivePeople[i] = new People(rn.Next(55, 70), Convert.ToString((Names)rn.Next(1, 20)), rn.Next(23, 35));
			}

			return collectivePeople;
		}
	}
}