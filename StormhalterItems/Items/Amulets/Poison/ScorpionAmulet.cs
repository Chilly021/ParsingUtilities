using System;
using System.Collections.Generic;
using System.IO;

namespace Kesmai.Server.Items
{
	public partial class ScorpionAmulet : Amulet
	{
		
		/// <summary>
		/// Gets the price.
		/// </summary>
		public  uint BasePrice => 250;

		/// <summary>
		/// Gets the weight.
		/// </summary>
		public  int Weight => 100;

		public ScorpionAmulet() 
		{
		}
	}
}