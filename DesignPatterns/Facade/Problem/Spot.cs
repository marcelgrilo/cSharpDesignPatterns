using System;
using System.Collections.Generic;
using System.Text;

namespace Facade.Problem
{
	public class Spot
	{
		private int number;
		public int Number
		{
			get { return number; }
			set { number = value; }
		}

		private DateTime _in;
		public DateTime In
		{
			get { return _in; }
			set { _in = value; }
		}

		private DateTime _out;
		public DateTime Out
		{
			get { return _out; }
			set { _out = value; }
		}




	}
}
