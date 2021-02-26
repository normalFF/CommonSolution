using System;
using System.Collections;
using UsingLibrary;
using Task3.IEnumerableObjects;

namespace Task3
{
	class Program
	{
		static void Main(string[] args)
		{
			People[] people = new People[] { new People(67, "Tom", 23), 
											new People(65, "Sam", 25), 
											new People(70, "Jack", 30), 
											new People(73, "Chris", 26) };

			CollectivePeople collective = new CollectivePeople(people);
			foreach (People p in collective)
			{
				Console.WriteLine(p.ToString());
			}

			Console.WriteLine("\n");
			IEnumerator pers = people.GetEnumerator();

			while (pers.MoveNext())
			{
				People p = (People)pers.Current;
				Console.WriteLine(p.ToString());
			}
			//===============================================
			Console.WriteLine("_____________________\n");

			Transport[] transport = new Transport[] {
									new Car("Acura", 150, 4, 1850),
									new Car("Subaru", 189, 4, 1800), 
									new Train("Fe", "Coal", 180, 300, 12500),
									new Train("CSX", "Coal", 190, 320, 12900)};

			TransportEnumerable setTransport = new TransportEnumerable(transport);
			foreach (Transport transp in setTransport)
			{
				Console.WriteLine(transp.ToString());
			}

			Console.WriteLine("\n");
			IEnumerator trans = transport.GetEnumerator();
			
			while (trans.MoveNext())
			{
				Transport t = (Transport)trans.Current;
				Console.WriteLine(t.ToString());
			}
			Console.ReadKey();
		}
	}
}