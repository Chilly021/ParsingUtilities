using System.Collections.Generic;
using System.IO;






namespace Kesmai.Server.Items
{
	public partial class ShieldRing : Ring
	{
		/// <summary>
		/// Gets the price.
		/// </summary>
		public  uint BasePrice => 750;
		
		/// <summary>
		/// Gets the weight.
		/// </summary>
		public  int Weight => 20;

		/// <summary>
		/// Gets or sets the shield-value provided by this ring.
		/// </summary>
		
		
		public virtual int Shield => 3;

		public ShieldRing() 
		{
		}
	}
}
