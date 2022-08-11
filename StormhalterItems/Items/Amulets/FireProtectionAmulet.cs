using System;
using System.Collections.Generic;
using System.IO;




namespace Kesmai.Server.Items
{
	public partial class FireProtectionAmulet : Amulet
	{
		/// <summary>
		/// Gets the price.
		/// </summary>
		public  uint BasePrice => 500;

		/// <summary>
		/// Gets the weight.
		/// </summary>
		public  int Weight => 100;

		/// <summary>
		/// Initializes a new instance of the <see cref="FireProtectionAmulet"/> class.
		/// </summary>
		public FireProtectionAmulet() 
		{
		}
		
		/// <summary>
		/// Gets the description for this instance.
		/// </summary>
		
	}
}
