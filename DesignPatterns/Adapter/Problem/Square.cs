using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.Problem
{
	public class Square : Polygon
	{

		private float side;
		public float Side
		{
			get { return side; }
			set { side = value; }
		}

		public override float Area()
		{
			return side * side;
		}
	}
}
