using System;
using System.Collections.Generic;
using System.IO;



namespace Kesmai.Server.Items
{
	public partial class SteelShield : Shield
	{
		/// <inheritdoc />
		public  uint BasePrice => 300;

		/// <inheritdoc />
		public  int Weight => 3000;

		/// <inheritdoc />
		public  int Category => 1;
		
		/// <inheritdoc />
		public  int BaseArmorBonus => 1;

		/// <inheritdoc />
		public  int ProjectileProtection => 3;

		/// <summary>
		/// Initializes a new instance of the <see cref="SteelShield"/> class.
		/// </summary>
		public SteelShield() 
		{
		}
	}
}
