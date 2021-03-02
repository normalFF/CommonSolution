using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Task2 //Мы можем изменить название namespace'a на более подходящее, например BoxingUnboxing?
{
	class Program
	{
		static void Main(string[] args) //Почему бы не увеличить объём данных для демострации?
		{
			Stopwatch stopwatch = new Stopwatch();

			int[] num = new int[5] { 23, 346, 123, 36, 457 };
			int[] num2 = new int[5];
			object ob;

			for (int i = 0; i < num.Length; i++)
			{
				stopwatch.Restart();
				ob = num[i];
				stopwatch.Stop();
				Console.Write($"{stopwatch.ElapsedTicks} : ");
				stopwatch.Restart();
				num2[i] = (int)ob;
				stopwatch.Stop();
				Console.WriteLine(stopwatch.ElapsedTicks);
			}

			Console.WriteLine("\n");

			for (int i = 0; i < num.Length; i++)
			{
				stopwatch.Restart();
				num2[i] = num[i];
				stopwatch.Stop();
				Console.WriteLine(stopwatch.ElapsedTicks);
			}

			Console.ReadKey();
		}
	}
}
