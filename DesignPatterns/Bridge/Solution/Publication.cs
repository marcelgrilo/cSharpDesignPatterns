namespace Bridge.Solution
{
	public class Publication
	{
		public string Name { get; set; }
		public string Author { get; set; }
		public float Price { get; set; }
		public Tax Tax { get; set; }

		public Publication(Tax tax)
		{
			Tax = tax;
		}

		public float CalculateTax()
		{
			return Tax.CalculateTax(Price);
		}

	}
}
