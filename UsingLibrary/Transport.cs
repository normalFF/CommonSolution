using System;
using System.Collections.Generic;
using System.Text;

namespace UsingLibrary
{
	public abstract class Transport : BaseObject
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

		public Transport(double mass, double maxSpeed, int numberSeats) : base(mass)
		{
			_maxSpeed = maxSpeed;
			_numbersSeats = numberSeats;
		}

		public override string ToString()
		{
			return $"\nМасса: {Mass}\nМаксимальная скорость: {MaxSpeed}\nКоличество мест: {NumbersSeats}\n";
		}

		public abstract void TravelType();
	}
}