using Adapter.Problem;
using Adapter.Solution;
using System;
using System.Collections.Generic;

/// <summary>
/// O objetivo é converter a interface de uma classe em outra interface esperada pelos clientes.
/// Adapter permite a comunicação entre classes que não poderiam trabalhar juntas devido à incompatibilidade de suas interfaces.
/// Uma comparação muito parecida com este padrão é o de adaptadores de tomadas. cada país usa um padrão, e então existem diversos adaptadores para se conectar aparelhos com padrões diferentes à rede elétrica destes países.
/// </summary>
namespace Adapter
{
	public class Program
	{
		public static void Main(string[] args)
		{
			List<Polygon> polygons = new List<Polygon>();

			polygons.Add(new Square() { Side = 10 });
			polygons.Add(new Triangle() { Base = 5, Height = 10 });
			polygons.Add(new ForeignerHexagonAdapter() { Side = 5 });

			foreach (var poly in polygons)
			{
				Console.WriteLine($"Area: {poly.Area()}" );
			}
			Console.Read();
		}
	}
}