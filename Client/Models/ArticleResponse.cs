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
	}
}