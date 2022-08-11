using System.Collections.Generic;
using System.IO;




namespace Kesmai.Server.Items
{
	public partial class BreatheWaterBracelet : Bracelet
	{
		/// <inheritdoc />
		public  uint BasePrice => 2000;

		/// <inheritdoc />
		public  int Weight => 4;

		/// <summary>
		/// Initializes a new instance of the <see cref="BreatheWaterBracelet"/> class.
		/// </summary>
		public BreatheWaterBracelet() 
		{
		}
	
	}
}