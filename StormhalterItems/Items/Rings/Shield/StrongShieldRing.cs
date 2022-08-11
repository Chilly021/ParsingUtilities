using System.Collections.Generic;
using System.IO;


namespace Kesmai.Server.Items
{
	public partial class StrongShieldRing : ShieldRing
	{
		/// <summary>
		/// Gets the price.
		/// </summary>
		public  uint BasePrice => 2000;

		/// <summary>
		/// Gets or sets the shield-value provided by this ring.
		/// </summary>
		public  int Shield => 6;

		/// <summary>
		/// Initializes a new instance of the <see cref="StrongShieldRing"/> class.
		/// </summary>
		public StrongShieldRing()
		{
		}
	}
}
