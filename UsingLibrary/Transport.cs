using System;

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

			if (numberSeats < 0)
				throw new ArgumentOutOfRangeException("Количество мест не может быть отрицательным числом");
			_numbersSeats = numberSeats;
		}

		public override string ToString()
		{
			return $"\nМасса: {Mass}\nМаксимальная скорость: {MaxSpeed}\nКоличество мест: {NumbersSeats}\n";
		}

		public abstract void TravelType();
	}
}