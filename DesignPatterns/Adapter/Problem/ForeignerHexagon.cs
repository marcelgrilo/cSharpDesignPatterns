using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.Problem
{
	/// <summary>
	/// Esta classe nao pode ser vista como um poligono.. Assim, este é um problema que pode ser solucionado com um adapter.
	/// </summary>
	public class ForeignerHexagon
	{
		private float side;
		public float Side
		{
			get { return side; }
			set { side = value; }
		}

		public float CalculateArea() 
		{
			return 6.0f * (float)(side * side * Math.Sqrt(3.0f) ) / 4.0f;
		}

	}
}
