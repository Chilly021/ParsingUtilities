using System;
using System.Collections.Generic;
using System.IO;



namespace Kesmai.Server.Items
{
	public partial class PlatedShield : Shield
	{
		/// <inheritdoc />
		public  uint BasePrice => 150;

		/// <inheritdoc />
		public  int Weight => 2000;

		/// <inheritdoc />
		public  int Category => 1;
		
		/// <inheritdoc />
		public  int BaseArmorBonus => 1;

		/// <inheritdoc />
		public  int ProjectileProtection => 2;

		/// <summary>
		/// Initializes a new instance of the <see cref="PlatedShield"/> class.
		/// </summary>
		public PlatedShield()
		{
		}
		

	}
}
