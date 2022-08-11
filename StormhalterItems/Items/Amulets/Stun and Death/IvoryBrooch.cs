using System.Collections.Generic;
using System.IO;


namespace Kesmai.Server.Items
{
	public partial class IvoryBrooch : StunDeathProtectionAmulet
	{
		/// <summary>
		/// Gets the label number.
		/// </summary>
		public  int LabelNumber => 6000020;

		/// <summary>
		/// Gets the price.
		/// </summary>
		public  uint BasePrice => 3000;

		/// <summary>
		/// Gets the weight.
		/// </summary>
		public  int Weight => 100;
		
		
		/// <summary>
		/// Initializes a new instance of the <see cref="IvoryBrooch"/> class.
		/// </summary>
		public IvoryBrooch() 
		{
		}
		
	}
}