using System.Collections.Generic;
using System.IO;




namespace Kesmai.Server.Items
{
	public partial class FeatherFallBoots : Boots
	{
		/// <inheritdoc />
		public  uint BasePrice => 1500;

		/// <inheritdoc />
		public  int Weight => 480;

		/// <inheritdoc />
		public  int Hindrance => 4;

		/// <summary>
		/// Initializes a new instance of the <see cref="FeatherFallBoots"/> class.
		/// </summary>
		public FeatherFallBoots()
		{
		}

		
	}
}
