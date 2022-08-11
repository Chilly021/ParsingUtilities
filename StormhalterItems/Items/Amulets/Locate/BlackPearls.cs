using System;
using System.Collections.Generic;
using System.IO;


namespace Kesmai.Server.Items
{
	public partial class BlackPearls : LocateAmulet
	{
		/// <summary>
		/// Gets the price.
		/// </summary>
		public  uint BasePrice => 600;
		
		/// <summary>
		/// Gets the weight.
		/// </summary>
		public  int Weight => 100;
		
		public BlackPearls() 
		{
		}
		

	}
}