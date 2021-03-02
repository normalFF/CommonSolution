using System;

namespace UsingLibrary
{
	public class BaseObject
	{
		protected double _mass;

		public double Mass
		{
			get
			{
				return _mass;
			}
		}

		public BaseObject(double mass) //Мы нигде не собираем BaseObject, кроме как в дочернем классе public -> protected
		{
			if (mass <= 0)
				throw new ArgumentOutOfRangeException("Масса не может быть отрицательной!");
			_mass = mass;
		}
	}
}