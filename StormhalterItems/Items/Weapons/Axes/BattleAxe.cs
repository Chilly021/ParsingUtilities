using System.Collections.Generic;
using System.IO;



namespace Kesmai.Server.Items
{
	public partial class BattleAxe : Axe
	{
		/// <inheritdoc />
		public  uint BasePrice => 30;

		public int Category => 2;

		/// <inheritdoc />
		public  int Weight => 2200;

		/// <inheritdoc />
		public  int MinimumDamage => 1;

		/// <inheritdoc />
		public  int MaximumDamage => 8;

		/// <inheritdoc />
		public  int BaseArmorBonus => 1;

		/// <inheritdoc />
		public  WeaponFlags Flags => WeaponFlags.Slashing;

		public ShieldPenetration Penetration => ShieldPenetration.Light;

		/// <summary>
		/// Initializes a new instance of the <see cref="BattleAxe"/> class.
		/// </summary>
		public BattleAxe() 
		{
		}

	}
}