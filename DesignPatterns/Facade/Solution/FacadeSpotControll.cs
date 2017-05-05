using Facade.Problem;
using System;
using System.Collections.Generic;
using System.Text;

namespace Facade.Solution
{
	/// <summary>
	/// Para se evitar que haja acoplamento entre as classes Client e Spot criou-se a classe FacadeSpotControll, que implementa métodos do relacionamento entre esdtas duas classes.
	/// Basicamente prove uma interface unificada para um método que agrega a utilização de diversos subsistemas, facilitando o uso destes subsistemas.
	/// </summary>
	public class FacadeSpotControll
	{
		private Client client;
		private Spot spot;

		public FacadeSpotControll(Client client, Spot spot)
		{
			this.client = client;
			this.spot = spot;
		}

		public string CarLicencePlate
		{
			get { return client.LicencePlate; }
			set { client.LicencePlate = value; }
		}

		public int CarSpotNumber
		{
			get { return spot.Number; }
			set { spot.Number = value; }
		}

	}
}
