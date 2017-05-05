using Composite.Example1;
using Composite.Example2;
using System;

namespace Composite
{
	/// <summary>
	/// Este padrão é utilizado para compor objetos em estruturas de árvore para representar hierarquias todo-parte.
	/// Permitindo que clientes tratem objetos individuais e composições de objetos de maneira uniforme.
	/// 
	/// Sempre que houver necessidade de tratar um conjunto como um indivíduo.
	/// Deve-se tomar cuidado com recursões infinitas.
	/// 
	/// 
	/// </summary>
	class Program
	{
		static void Main(string[] args)
		{

			Console.WriteLine("Example 1\n");
			Example1();
			Console.WriteLine();
			Console.WriteLine("Example 2\n");
			Example2();
			

			

			Console.Read();

		}

		private static void Example2()
		{
			Chapter c1 = new Chapter(10, "OO");
			Chapter c2 = new Chapter(20, "Abstraction");

			c1.AddPublication(c2);

			Section s1 = new Section(1, "Constructors");
			Section s2 = new Section(2, "Visibility");

			c2.AddPublication(s1);
			c2.AddPublication(s2);

			Chapter c3 = new Chapter(20, "Relationships");

			c1.AddPublication(c3);

			Section s3 = new Section(3, "Associations");

			c3.AddPublication(s3);


			Console.WriteLine($"{c1.Title}[{c1.TotalPages()}]");
			Console.WriteLine($"|--{c2.Title}[{c2.TotalPages()}]");
			Console.WriteLine($"|--|--{s1.Title}[{s1.TotalPages()}]");
			Console.WriteLine($"|--|--{s2.Title}[{s2.TotalPages()}]");
			Console.WriteLine($"|---{c3.Title}[{c3.TotalPages()}]");
			Console.WriteLine($"|--|--{s3.Title}[{s3.TotalPages()}]");
		}

		private static void Example1()
		{
			// Create a tree structure 
			CompositeElement root = new CompositeElement("Picture");
			root.Add(new PrimitiveElement("Red Line"));
			root.Add(new PrimitiveElement("Blue Circle"));
			root.Add(new PrimitiveElement("Green Box"));

			// Create a branch
			CompositeElement comp = new CompositeElement("Two Circles");
			comp.Add(new PrimitiveElement("Black Circle"));
			comp.Add(new PrimitiveElement("White Circle"));
			root.Add(comp);

			// Add and remove a PrimitiveElement
			PrimitiveElement pe = new PrimitiveElement("Yellow Line");
			root.Add(pe);
			root.Remove(pe);

			// Recursively display nodes
			root.Display(1);
		}
	}
}