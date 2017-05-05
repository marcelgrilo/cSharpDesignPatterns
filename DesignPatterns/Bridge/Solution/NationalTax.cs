namespace Bridge.Solution
{
	public class NationalTax : Tax
	{
		public override float CalculateTax(float price)
		{
			return price * 0.3f;
		}
	}
}
