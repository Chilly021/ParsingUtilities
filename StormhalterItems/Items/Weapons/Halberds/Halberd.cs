using System.Collections.Generic;
using System.IO;



namespace Kesmai.Server.Items
{
	public partial class Halberd : MeleeWeapon
	{
		/// <inheritdoc />
		public  int LabelNumber => 6000046;

		/// <inheritdoc />
		public  uint BasePrice => 40;

		/// <inheritdoc />
		public  int Weight => 4800;

		/// <inheritdoc />
		public  ShieldPenetration Penetration => ShieldPenetration.Medium;

		/// <inheritdoc />
		public  int Category => 15;

		/// <inheritdoc />
		public  int MinimumDamage => 1;

		/// <inheritdoc />
		public  int MaximumDamage => 12;

		/// <inheritdoc />
		public  int BaseArmorBonus => 2;

		/// <inheritdoc />
		public  Skill Skill => Skill.Halberd;

		/// <inheritdoc />
		public  WeaponFlags Flags => WeaponFlags.TwoHanded | WeaponFlags.Slashing | WeaponFlags.Bashing;

		/// <summary>
		/// Initializes a new instance of the <see cref="Halberd" /> class.
		/// </summary>
		public Halberd() 
		{
		}

	
	}
}
