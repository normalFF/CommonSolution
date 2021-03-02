using System;
using System.Collections.Generic;
using System.Text;

namespace UsingLibrary
{
	public abstract class Transport : BaseObject
	{
		protected double _maxSpeed;  //может лучше для полей использовать private?
		protected int _numbersSeats;  //а лучше, на мой взгляд вообще их не писать, так как поля и так генерятся автоматом и сделать, как я исправил в BaseObject

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
			if(maxSpeed<0)
			       throw new ArgumentException("Скорость не может быть отрицательной");
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
