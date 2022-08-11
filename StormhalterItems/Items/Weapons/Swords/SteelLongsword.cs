using System.Collections.Generic;
using System.IO;


namespace Kesmai.Server.Items
{
	public partial class SteelLongsword : Longsword
	{
		/// <inheritdoc />
		public  uint BasePrice => 1500;
		
		/// <inheritdoc />
		public  int BaseAttackBonus => 4;

		/// <summary>
		/// Initializes a new instance of the <see cref="SteelLongsword"/> class.
		/// </summary>
		public SteelLongsword()
		{
		}

	}
}