namespace Bridge.Solution
{
	public class Magazine : Publication
	{
		public int Year { get; set; }
		public int Month { get; set; }

		public Magazine(Tax tax) : base(tax)
		{
		}
	}
}
