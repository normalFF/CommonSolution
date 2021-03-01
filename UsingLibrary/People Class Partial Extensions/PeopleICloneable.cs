using System;
using System.Collections.Generic;
using System.Text;

namespace UsingLibrary
{

	public partial class People : ICloneable
	{
		public object Clone()
		{
			return new People(this.Mass, this.Name, this.Age);
		}
	}
}
