using System.Collections.Generic;
using System.IO;


namespace Kesmai.Server.Items
{
	public partial class JadeAmulet : LocateAmulet
	{
		/// <summary>
		/// Gets the price.
		/// </summary>
		public  uint BasePrice => 400;

		/// <summary>
		/// Gets the weight.
		/// </summary>
		public  int Weight => 100;

		/// <summary>
		/// Initializes a new instance of the <see cref="JadeAmulet"/> class.
		/// </summary>
		public JadeAmulet() 
		{
		}
	
	}
}