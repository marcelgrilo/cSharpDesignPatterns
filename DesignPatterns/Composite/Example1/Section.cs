using System;
using System.Collections.Generic;
using System.Text;

namespace Composite.Example1
{
	public class Section : Publication
	{
		public Section(int numberOfPages, string title) : base(numberOfPages, title)
		{
		}

		public override int TotalPages()
		{
			return NumberOfPages;
		}
	}
}
