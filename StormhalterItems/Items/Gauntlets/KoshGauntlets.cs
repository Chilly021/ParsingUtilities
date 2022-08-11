using System.Collections.Generic;
using System.IO;



namespace Kesmai.Server.Items
{
	public partial class KoshGauntlets : Gauntlets
	{
		/// <inheritdoc />
		public  int LabelNumber => 6000041;

        /// <inheritdoc />
		public  uint BasePrice => 1;

        /// <inheritdoc />
		public  int Weight => 200;

        /// <inheritdoc />
		public  ShieldPenetration Penetration => ShieldPenetration.Heavy;

        /// <inheritdoc />
		public  int MinimumDamage => 1;

        /// <inheritdoc />
		public  int MaximumDamage => 4;

        /// <inheritdoc />
		public  int BaseArmorBonus => 1;

        /// <inheritdoc />
		public  int BaseAttackBonus => 2;

        /// <inheritdoc />
		public  WeaponFlags Flags => base.Flags | WeaponFlags.BlueGlowing;

        /// <inheritdoc />
		public  bool CanBind => true;

		/// <summary>
		/// Initializes a new instance of the <see cref="KoshGauntlets"/> class.
		/// </summary>
		public KoshGauntlets() 
		{
		}

	}
}