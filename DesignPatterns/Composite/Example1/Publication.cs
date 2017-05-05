using System;
using System.Collections.Generic;
using System.Text;

namespace Composite.Example1
{
	public abstract class Publication
	{
		private int numberOfPages;
		public int NumberOfPages 
		{
			get { return numberOfPages; }
			set { numberOfPages = value; }
		}

		private string title;
		public string Title 
		{
			get { return title;}
			set { title = value; }
		}

		public Publication(int numberOfPages, string title)
		{
			this.numberOfPages = numberOfPages;
			this.title = title;
		}

		public abstract int TotalPages();

	}
}
