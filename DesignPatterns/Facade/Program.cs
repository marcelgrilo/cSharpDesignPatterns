using Facade.Solution;
using System;

namespace Facade
{
	/// <summary>
	/// Seu objetivo é fornecer uma interface ún ica para um conjunto de interfaces de um subsistema.
	/// Facade define um ainterface de nivel mais elevado que torna o subsistema mais fácil de ser usado.
	/// 
	/// Facade deve ser aplicado quando clientes de um subsistema forem utilizar apenas parte da funcionalidade dele. Então o Facade prove uma interface mais fácil de usar co que todo o subsistema.
	/// E também quando existem muitas dependencia entre subsistemas, o que dificulta a manutenção.
	/// 
	/// Com o facade evita-se que exiata comunicação entre os clientes(Client e Spot)
	/// </summary>
	class Program
	{
		static void Main(string[] args)
		{

			FacadeSpotControll fsc = new FacadeSpotControll(new Problem.Client() { LicencePlate = "123456", Name = "Jhon" }, new Problem.Spot(){ Number=123, In = new DateTime(2017,01,02,14,15,16), Out = new DateTime(2017, 02, 03, 15, 16, 17) });
			Console.WriteLine($"{fsc.CarLicencePlate} : {fsc.CarSpotNumber}");
			Console.Read();
		}
	}
}