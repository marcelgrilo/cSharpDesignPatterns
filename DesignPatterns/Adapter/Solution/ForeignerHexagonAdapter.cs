using Adapter.Problem;
using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.Solution
{
	/// <summary>
	/// Implementação de um adaptador para a classe ForeignerHexagon.
	/// Neste caso a classe ForeignerHexagon esta no mesmo namespace, porém o adapter é geralmente utilizado para adaptar classes de uma dll por exemplo, sendo que ForeignerHexagon fora criado no mesmo namespace para simplificação e demonstração do padrão de projeto. 
	/// Observa-se que o padrão adapter esconde que ForeignerHexagonAdapter utiliza um ForeignerHexagon e apenas expoe o necessario para a manutenção do objeto em questão.
	/// </summary>
	public class ForeignerHexagonAdapter : Polygon
	{
		private ForeignerHexagon _fh;
		
		public float Side
		{
			get { return _fh.Side; }
			set { _fh.Side = value; }
		}

		public ForeignerHexagonAdapter()
		{
			_fh = new ForeignerHexagon();
		}

		public override float Area()
		{
			return _fh.CalculateArea();
		}
	}
}
