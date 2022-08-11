using System.Collections.Generic;
using System.IO;



namespace Kesmai.Server.Items
{
	public partial class SilverGreatAxe : Axe
	{
		/// <inheritdoc />
		public  uint BasePrice => 1;

		/// <inheritdoc />
		public  int Weight => 5760;

		/// <inheritdoc />
		public  int LabelNumber => 6000044;

		/// <inheritdoc />
		public  int Category => 1;

		/// <inheritdoc />
		public  ShieldPenetration Penetration => ShieldPenetration.VeryHeavy;

		/// <inheritdoc />
		public  int MinimumDamage => 4;

		/// <inheritdoc />
		public  int MaximumDamage => 14;

		/// <inheritdoc />
		public  int BaseArmorBonus => 1;

		/// <inheritdoc />
		public  int BaseAttackBonus => 4;

		/// <inheritdoc />
		public  Skill Skill => Skill.Greatsword;

		/// <inheritdoc />
		public  WeaponFlags Flags => WeaponFlags.TwoHanded | WeaponFlags.Silver | WeaponFlags.Slashing 
		                                     | WeaponFlags.Lawful | WeaponFlags.BlueGlowing;

        /// <inheritdoc />
		public  bool CanBind => true;

		/// <summary>
		/// Initializes a new instance of the <see cref="SilverGreatAxe"/> class.
		/// </summary>
		
	}
}