using System;

namespace UsingLibrary
{
	public class Worker : People
	{
		private string _company;

		public string Company
		{
			get
			{
				return _company;
			}
		}

		public Worker(double mass, string name, int age, string company) : base(mass, name, age)
		{
			_company = company ?? throw new ArgumentNullException("Company не может быть null");
		}

		public override string ToString()
		{
			return base.ToString() + $" компания: {Company}";
		}
	}
}
