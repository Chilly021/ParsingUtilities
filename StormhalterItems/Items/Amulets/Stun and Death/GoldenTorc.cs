using System;
using System.Collections.Generic;
using System.IO;


namespace Kesmai.Server.Items
{
	public partial class GoldenTorc : StunDeathProtectionAmulet
	{
		/// <summary>
		/// Gets the label number.
		/// </summary>
		public  int LabelNumber => 6000092;

		/// <summary>
		/// Gets the price.
		/// </summary>
		public  uint BasePrice => 1500;

		/// <summary>
		/// Gets the weight.
		/// </summary>
		public  int Weight => 150;
		
		public GoldenTorc() 
		{
		}
	
	}
}