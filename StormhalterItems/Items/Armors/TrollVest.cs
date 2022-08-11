using System.Collections.Generic;
using System.IO;


namespace Kesmai.Server.Items
{
	public partial class TrollVest : Armor
	{
		/// <inheritdoc />
		public  int LabelNumber => 6000096; /* vest */

		/// <inheritdoc />
		public  uint BasePrice => 150;

		/// <inheritdoc />
		public  int Weight => 1800;

		/// <inheritdoc />
		public  int Hindrance => 1;

		/// <inheritdoc />
		public  int SlashingProtection => 2;

		/// <inheritdoc />
		public  int PiercingProtection => 2;

		/// <inheritdoc />
		public  int BashingProtection => 2;

		/// <inheritdoc />
		public  int ProjectileProtection => 2;

		/// <summary>
		/// Initializes a new instance of the <see cref="TrollVest"/> class.
		/// </summary>
		public TrollVest() 
		{
		}


	}
}
