using System;
using System.Collections.Generic;
using System.IO;




namespace Kesmai.Server.Items
{
	public partial class LightningShield : Shield
	{
		/// <inheritdoc />
		public  uint BasePrice => 2000;

		/// <inheritdoc />
		public  int Weight => 3000;

		/// <inheritdoc />
		public  int Category => 1;
		
		/// <inheritdoc />
		public  int BaseArmorBonus => 1;

		/// <inheritdoc />
		public  int ProjectileProtection => 4;

		/// <summary>
		/// Initializes a new instance of the <see cref="LightningShield"/> class.
		/// </summary>
		public LightningShield() 
		{
		}

	}
}
