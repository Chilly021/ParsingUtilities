using System.Collections.Generic;
using System.IO;

namespace Kesmai.Server.Items
{
	public partial class IceProtectionRing : Ring
	{
		/// <summary>
		/// Gets the price.
		/// </summary>
		public  uint BasePrice => 300;

		/// <summary>
		/// Gets the weight.
		/// </summary>
		public  int Weight => 20;

		/// <summary>
		/// Initializes a new instance of the <see cref="IceProtectionRing"/> class.
		/// </summary>
		public IceProtectionRing()
		{
		}
	}
}