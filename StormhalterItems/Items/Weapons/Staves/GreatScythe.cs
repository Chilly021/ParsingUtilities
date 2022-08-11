using System.Collections.Generic;
using System.IO;



namespace Kesmai.Server.Items
{
	public partial class GreatScythe : Staff
	{
		/// <inheritdoc />
		public  uint BasePrice => 10000;

		/// <inheritdoc />
		public  int Weight => 1400;

        /// <inheritdoc />
        public  ShieldPenetration Penetration => ShieldPenetration.VeryHeavy;

        /// <inheritdoc />
		public  int MinimumDamage => 8;

		/// <inheritdoc />
		public  int MaximumDamage => 15;

        /// <inheritdoc />
        public  bool CanBind => true;

		/// <inheritdoc />
		public  int BaseArmorBonus => 3;

		/// <inheritdoc />
		public  int BaseAttackBonus => 6;

        /// <inheritdoc />
        public  int ProjectileProtection  => 1;

		/// <inheritdoc />
		public  WeaponFlags Flags => WeaponFlags.TwoHanded | WeaponFlags.Bashing | WeaponFlags.Lawful;
		
		/// <summary>
		/// Initializes a new instance of the <see cref="GreatScythe"/> class.
		/// </summary>
		public GreatScythe()
		{
		}
	}
}
