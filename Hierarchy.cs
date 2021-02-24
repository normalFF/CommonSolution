using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
	class BaseObject
	{
		protected double _mass;

		public double Mass
		{
			get
			{
				return _mass;
			}
		}

		public BaseObject(double Mass)
		{
			_mass = Mass;
		}
	}


	class Human : BaseObject
	{
		protected string _name;
		protected int _age;

		public string Name
		{
			get
			{
				return _name;
			}
		}
		public int Age
		{
			get
			{
				return _age;
			}
		}

		public Human(double Mass, string Name, int Age) : base(Mass)
		{
			_name = Name;
			_age = Age;
		}
	}

	class Worker : Human
	{
		string _company;

		public string Company
		{
			get
			{
				return _company;
			}
		}

		public Worker(double Mass, string Name, int Age, string Company) : base(Mass, Name, Age)
		{
			_company = Company;
		}
	}


	abstract class Transport : BaseObject
	{
		protected double _maxSpeed;
		protected int _numbersSeats;

		public double MaxSpeed
		{
			get
			{
				return _maxSpeed;
			}
		}
		public int NumbersSeats
		{
			get
			{
				return _numbersSeats;
			}
		}

		public Transport(double Mass, double MaxSpeed, int NumberSeats) : base(Mass)
		{
			_maxSpeed = MaxSpeed;
			_numbersSeats = NumberSeats;
		}

		public abstract void TravelType();
	}

	class Train : Transport
	{
		private string _manufactuter;
		private string _fuelType;

		public string Manufacturer
		{
			get
			{
				return _manufactuter;
			}
		}
		public string FuelType
		{
			get
			{
				return _fuelType;
			}
		}

		public Train(string Manufacturer, string Fuel, double MaxSpeed, int NumbersSeats, double Mass) : base(Mass, MaxSpeed, NumbersSeats)
		{
			_manufactuter = Manufacturer;
			_fuelType = Fuel;
		}

		public override void TravelType()
		{
			Console.WriteLine("Moves in special ways");
		}
	}

	class Car : Transport
	{
		private string _brand;

		public string Brand
		{
			get
			{
				return _brand;
			}
		}

		public Car(string Brand, double MaxSpeed, int NumbersSeats, double Mass) : base(Mass, MaxSpeed, NumbersSeats)
		{
			_brand = Brand;
		}

		public override void TravelType()
		{
			Console.WriteLine("Moves in ordinary roads");
		}
	}
}
