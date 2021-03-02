﻿using System;
using UsingLibrary;

namespace Task1 //Мы можем изменить название namespace'a на более подходящее, например OOP?
{
	class Program
	{
		static void Main(string[] args)
		{
			People people = new People(65, "Tom", 32);
			Worker worker = new Worker(60, "Jack", 30, "NotCompany");

			Console.WriteLine(people.ToString());
			Console.WriteLine(worker.ToString());

			Train train = new Train("Null", "Null", 150, 300, 5000);
			Car car = new Car("Null", 200, 4, 2500);

			Console.ReadKey();
		}
	}
}
