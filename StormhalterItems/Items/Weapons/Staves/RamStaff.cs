using System.Collections.Generic;
using System.IO;



namespace Kesmai.Server.Items
{
	public partial class RamStaff : Staff
	{
		/// <inheritdoc />
		public  uint BasePrice => 800;

		/// <inheritdoc />
		public  int Weight => 1400;

        /// <inheritdoc />
        public  ShieldPenetration Penetration => ShieldPenetration.Medium;

        /// <inheritdoc />
		public  int MinimumDamage => 1;

		/// <inheritdoc />
		public  int MaximumDamage => 8;

        /// <inheritdoc />
        public  bool CanBind => true;

		/// <inheritdoc />
		public  int BaseArmorBonus => 4;

		/// <inheritdoc />
		public  int BaseAttackBonus => 2;

        /// <inheritdoc />
        public  int ProjectileProtection  => 1;

		/// <inheritdoc />
		public  WeaponFlags Flags => WeaponFlags.TwoHanded | WeaponFlags.Bashing | WeaponFlags.Lawful;
		
		/// <summary>
		/// Initializes a new instance of the <see cref="RamStaff"/> class.
		/// </summary>
		public RamStaff() 
		{
		}
		
		
	}
}