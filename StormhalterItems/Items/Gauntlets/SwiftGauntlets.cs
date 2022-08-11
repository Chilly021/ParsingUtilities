using System;
using System.Collections.Generic;
using System.IO;



namespace Kesmai.Server.Items
{
	public partial class SwiftGauntlets : Gauntlets
	{
		/// <inheritdoc />
		public  uint BasePrice => 2000;

		/// <inheritdoc />
		public  int Weight => 100;
		
		/// <inheritdoc />
		public  int MinimumDamage => 1;

		/// <inheritdoc />
		public  int MaximumDamage => 4;

		/// <inheritdoc />
		public  int BaseAttackBonus => 2;
		
		/// <inheritdoc />
		public  WeaponFlags Flags => base.Flags | WeaponFlags.Neutral | WeaponFlags.Slashing;
		
		/// <inheritdoc />
		public  int ProjectileProtection => 1;
		
		public SwiftGauntlets()
		{
		}

	}
}