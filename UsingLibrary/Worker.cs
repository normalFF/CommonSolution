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
			_company = company;
		}

		public override string ToString()
		{
			return base.ToString() + $" компания: {Company}";
		}
	}
}
