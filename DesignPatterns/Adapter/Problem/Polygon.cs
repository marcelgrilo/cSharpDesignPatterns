using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.Problem
{
	public abstract class Polygon
	{
		private float x;
		public float X
		{
			get { return x; }
			set { x = value; }
		}

		private float y;
		public float Y
		{
			get { return y; }
			set { y = value; }
		}

		public abstract float Area();

	}
}
