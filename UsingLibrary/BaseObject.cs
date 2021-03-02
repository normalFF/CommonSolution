using System;

namespace UsingLibrary
{
	public class BaseObject
	{
		//мне кажется, что лучше сделать так:
		public double Mass {get; private set;}

		public BaseObject(double mass)
		{
			if (mass <= 0)
				throw new ArgumentOutOfRangeException("Масса не может быть отрицательной!"); //а тут не принципиально, но что-то мне подсказывает, что лучше ArgumentException))
			_mass = mass;
		}
	}
}
