using System.Collections.Generic;
using System.IO;




namespace Kesmai.Server.Items
{
	public partial class KnightRing : Ring
	{
		/// <summary>
		/// Gets the price.
		/// </summary>
		public  uint BasePrice => 150;
		
		/// <summary>
		/// Gets the weight.
		/// </summary>
		public  int Weight => 20;

		public  bool CanBind => true;

		/// <summary>
		/// Initializes a new instance of the <see cref="KnightRing"/> class.
		/// </summary>
		public KnightRing() 
		{
		}

		
	
	}
}
