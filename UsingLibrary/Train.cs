using System;

namespace UsingLibrary
{
	public class Train : Transport
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

		public Train(string manufacturer, string fuel, double maxSpeed, int numbersSeats, double mass) : base(mass, maxSpeed, numbersSeats)
		{
			_manufactuter = manufacturer ?? throw new ArgumentNullException("Manufacturer не может быть null");
			_fuelType = fuel ?? throw new ArgumentNullException("FuelType не может быть null");
		}

		public override void TravelType()
		{
			Console.WriteLine("Moves in special ways");
		}

		public override string ToString()
		{
			return $"Компания: {Manufacturer}\nТип топлива: {FuelType}" + base.ToString();
		}
	}
}
