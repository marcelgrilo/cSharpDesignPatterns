using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.Problem
{
	public class Triangle : Polygon
	{
		private float _base;
		public float Base
		{
			get { return _base; }
			set { _base = value; }
		}

		private float height;
		public float Height
		{
			get { return height; }
			set { height = value; }
		}


		public override float Area()
		{
			return (_base * height) / 2;
		}
	}
}
