using System.Collections.Generic;
using System.IO;



namespace Kesmai.Server.Items
{
	public partial class ReturningAxe : Axe
	{
		/// <inheritdoc />
		public  uint BasePrice => 1;

		/// <inheritdoc />
		public  int Weight => 2560;

		/// <inheritdoc />
		public  ShieldPenetration Penetration => ShieldPenetration.VeryHeavy;

		/// <inheritdoc />
		public  int MinimumDamage => 1;

		/// <inheritdoc />
		public  int MaximumDamage => 8;

		/// <inheritdoc />
		public  int BaseArmorBonus => 2;

		/// <inheritdoc />
		public  int BaseAttackBonus => 5;

		/// <inheritdoc />
		public  WeaponFlags Flags => WeaponFlags.BlueGlowing | WeaponFlags.Returning | WeaponFlags.Throwable 
		                                     | WeaponFlags.Slashing | WeaponFlags.Lawful;

        /// <inheritdoc />
		public  bool CanBind => true;

		/// <summary>
		/// Initializes a new instance of the <see cref="ReturningAxe"/> class.
		/// </summary>
		public ReturningAxe() 
		{
		}
	}
}