using System.Collections.Generic;
using System.IO;



namespace Kesmai.Server.Items
{
	public partial class SteelDagger : Dagger
	{
		/// <inheritdoc />
		public  uint BasePrice => 10;
		
		/// <inheritdoc />
		protected  int PoisonedItemId => 313;

		/// <summary>
		/// Initializes a new instance of the <see cref="SteelDagger"/> class.
		/// </summary>
		public SteelDagger()
		{ 
		}
		
	}
}