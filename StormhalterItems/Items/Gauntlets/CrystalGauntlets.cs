using System.Collections.Generic;
using System.IO;



namespace Kesmai.Server.Items
{
	public partial class CrystalGauntlets : Gauntlets
	{
		/// <inheritdoc />
		public  int LabelNumber => 6000041;

        /// <inheritdoc />
		public  uint BasePrice => 1500;

        /// <inheritdoc />
		public  int Weight => 200;

        /// <inheritdoc />
		public  ShieldPenetration Penetration => ShieldPenetration.VeryHeavy;

        /// <inheritdoc />
		public  int MinimumDamage => 1;

        /// <inheritdoc />
		public  int MaximumDamage => 6;

        /// <inheritdoc />
		public  int BaseArmorBonus => 3;

        /// <inheritdoc />
		public  int BaseAttackBonus => 4;

        /// <inheritdoc />
		public  WeaponFlags Flags => base.Flags | WeaponFlags.BlueGlowing | WeaponFlags.Lawful;

        /// <inheritdoc />
		public  bool CanBind => true;

		/// <summary>
		/// Initializes a new instance of the <see cref="CrystalGauntlets"/> class.
		/// </summary>
		public CrystalGauntlets() 
		{
		}

	}
}