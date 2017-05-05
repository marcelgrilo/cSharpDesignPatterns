namespace Bridge.Solution
{
	public class ImportedTax : Tax
	{
		public override float CalculateTax(float price)
		{
			return price * 0.5f;
		}
	}
}
