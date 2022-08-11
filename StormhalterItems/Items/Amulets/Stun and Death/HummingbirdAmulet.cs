using System.Collections.Generic;
using System.IO;


namespace Kesmai.Server.Items
{
	public partial class HummingbirdAmulet : StunDeathProtectionAmulet
	{
		/// <summary>
		/// Gets the price.
		/// </summary>
		public  uint BasePrice => 4500;

		/// <summary>
		/// Gets the weight.
		/// </summary>
		public  int Weight => 100;
		
		/// <summary>
		/// Initializes a new instance of the <see cref="HummingbirdAmulet"/> class.
		/// </summary>
		public HummingbirdAmulet() 
		{
		}

	}
}