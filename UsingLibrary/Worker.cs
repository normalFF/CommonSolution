using System;
using System.Collections.Generic;
using System.Text;

namespace UsingLibrary
{
	public class Worker : People
	{
		string _company; // можем прописать private явно

		public string Company
		{
			get
			{
				return _company;
			}
		}

		public Worker(double mass, string name, int age, string company) : base(mass, name, age)//string -> проверка на null
		{
			_company = company;
		}

		public override string ToString()
		{
			return base.ToString() + $" компания: {Company}";
		}
	}
}
