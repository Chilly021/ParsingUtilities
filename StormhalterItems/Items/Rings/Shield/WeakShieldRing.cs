using System.Collections.Generic;
using System.IO;



namespace Kesmai.Server.Items
{
	public partial class WeakShieldRing : ShieldRing
	{
		/// <summary>
		/// Gets the price.
		/// </summary>
		public  uint BasePrice => 250;

		/// <summary>
		/// Gets or sets the shield-value provided by this ring.
		/// </summary>
		public  int Shield => 1;

		/// <summary>
		/// Initializes a new instance of the <see cref="WeakShieldRing"/> class.
		/// </summary>
		public WeakShieldRing()
		{
		}

	}
}
