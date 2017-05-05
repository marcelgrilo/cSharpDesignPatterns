namespace Bridge.Solution
{
	public class Book : Publication
	{
		public string ISBN { get; set; }

		public Book(Tax tax) : base(tax)
		{
		}
	}
}
