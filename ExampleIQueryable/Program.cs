using System;
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
			var selected = collectivePeople.Where(testc => testc.Mass >= 58 && testc.Mass <= 60 && testc.Name.Length == 5);

			foreach (People p in selected)
			{
				Console.WriteLine(p.ToString());
			}

			Console.ReadKey();
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