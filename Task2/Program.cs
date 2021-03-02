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
			Random random = new Random();
			int[] ArrayNumbers = new int[1000000];
			object[] ArrayObjects = new object[1000000];

			for (int i = 0; i < ArrayNumbers.Length; i++)
			{
				ArrayNumbers[i] = random.Next(1, 40);
			}

			stopwatch.Start();
			for (int i = 0; i < ArrayNumbers.Length; i++)
			{
				ArrayObjects[i] = ArrayNumbers[i];
			}
			stopwatch.Stop();
			Console.WriteLine($"Времени затрачено на упаковку {ArrayObjects.Length} объектов : {stopwatch.ElapsedTicks}");

			stopwatch.Restart();
			for (int i = 0; i < ArrayNumbers.Length; i++)
			{
				ArrayNumbers[i] = (int)ArrayObjects[i];
			}
			stopwatch.Stop();
			Console.WriteLine($"Времени затрачено на распаковку {ArrayObjects.Length} объектов : {stopwatch.ElapsedTicks}");

			int[] ArrayNumbers2 = new int[1000000];
			stopwatch.Restart();
			for (int i = 0; i < ArrayNumbers.Length; i++)
			{
				ArrayNumbers2[i] = ArrayNumbers[i];
			}
			stopwatch.Stop();
			Console.WriteLine($"Времени затрачено на копирование массива длиной {ArrayObjects.Length} : {stopwatch.ElapsedTicks}");


			Console.ReadKey();
		}
	}
}