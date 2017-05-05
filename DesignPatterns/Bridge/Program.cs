using Bridge.Solution;
using System;

namespace Bridge
{
	/// <summary>
	/// Desacopla uma abstração de sua implementação para que os dois possam variar independentemente.
	/// 
	/// Consequencias:
	/// Detalhes de implementação totalmente inacessíveis aos clientes
	/// Eliminação de dependencias em tempo de compilação das implementações
	/// Implementação da abstração pode ser configurada em tempo de execução.
	/// 
	/// Aplicabilidade:
	/// Quando for necessário evitar uma ligação permanente entre a interface e implementação.
	/// Quando alterações na implementação não pudentem afetar clientes.
	/// quando tanto abstrações como implementações precisatem ser capazes de suportar extenção através de herança
	/// Quando implementações são comparilhadas entre objetos desconhecidos do cliente.
	/// </summary>
	class Program
	{
		static void Main(string[] args)
		{
			NationalTax nt = new NationalTax();
			Book b = new Book(nt) { Price = 100 };

			ImportedTax it = new ImportedTax();
			Magazine m = new Magazine(it) { Price = 10 };

			Console.WriteLine($" Book Tax: {b.CalculateTax()} \t Magazine Tax {m.CalculateTax()} ");

			Console.Read();
		}
	}
}