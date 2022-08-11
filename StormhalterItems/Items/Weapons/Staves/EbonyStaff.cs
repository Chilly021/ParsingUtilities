using System.Collections.Generic;
using System.IO;



namespace Kesmai.Server.Items
{
	public partial class EbonyStaff : Staff
	{
		/// <inheritdoc />
		public  int LabelNumber => 6000088;

		/// <inheritdoc />
		public  uint BasePrice => 1;

		/// <inheritdoc />
		public  int Weight => 1400;

		/// <inheritdoc />
		public  ShieldPenetration Penetration => ShieldPenetration.VeryHeavy;

		/// <inheritdoc />
		public  int MinimumDamage => 1;

		/// <inheritdoc />
		public  int MaximumDamage => 8;

		/// <inheritdoc />
		public  int BaseArmorBonus => 5; 
		
		/// <inheritdoc />
        public  int ProjectileProtection  => 3;

		/// <inheritdoc />
		public  WeaponFlags Flags => WeaponFlags.TwoHanded | WeaponFlags.Bashing | WeaponFlags.Lawful;

        /// <inheritdoc />
		public  bool CanBind => true;

        /// <inheritdoc />
        public  int ManaRegeneration => 1;

        /// <summary>
		/// Initializes a new instance of the <see cref="EbonyStaff"/> class.
		/// </summary>
		public EbonyStaff()
		{
		}

	}
}