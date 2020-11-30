using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Client.Models
{


	//{"data":{"articleCollection":{"items":[{"title":"Dummy title"}]}}}
	public class data
	{
		public Articlecollection articleCollection { get; set; }
	}

	public class Articlecollection
	{
		public Item[] items { get; set; }
	}

	public class Item
	{
		public string title { get; set; }
		public string slug { get; set; }
		public string tag { get; set; }
		public string author { get; set; }
		public HeroImage heroImage { get; set; }
		public string body { get; set; }
		public string shortDescription { get; set; }
		public DateTime postDate { get; set; }
	}

	public class HeroImage
	{
		public string url { get; set; }
		public string description { get; set; }

	}
}
