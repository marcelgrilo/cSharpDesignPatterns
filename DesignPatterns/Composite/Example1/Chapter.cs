using System;
using System.Collections.Generic;
using System.Text;

namespace Composite.Example1
{
	public class Chapter : Publication
	{

		private List<Publication> publications;
		public Chapter(int numberOfPages, string title) : base(numberOfPages, title)
		{
			publications = new List<Publication>();
		}

		public override int TotalPages()
		{
			int sum = NumberOfPages;
			for (int i = 0; i < publications.Count; i++)
			{
				sum += publications[i].TotalPages();
				
			}
			return sum;
		}

		public void AddPublication(Publication publication) 
		{
			publications.Add(publication);
		}

		public void RemovePublication(int index) 
		{
			publications.RemoveAt(index);
		}




	}
}
