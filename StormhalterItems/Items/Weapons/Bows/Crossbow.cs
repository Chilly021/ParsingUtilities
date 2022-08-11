using System.Collections.Generic;
using System.IO;



namespace Kesmai.Server.Items
{
	public partial class Crossbow : ProjectileWeapon
	{
		/// <inheritdoc />
		public  int LabelNumber => 6000031;

		/// <inheritdoc />
		public  uint BasePrice => 40;

		/// <inheritdoc />
		public  int Weight => 1200;

		/// <inheritdoc />
		public  int Category => 2;

		/// <inheritdoc />
		public  ShieldPenetration Penetration => ShieldPenetration.Light;

		/// <inheritdoc />
		public  int MinimumDamage => 1;

		/// <inheritdoc />
		public  int MaximumDamage => 8;

		/// <inheritdoc />
		public  Skill Skill => Skill.Bow;

		/// <inheritdoc />
		public  WeaponFlags Flags => WeaponFlags.TwoHanded | WeaponFlags.Crossbow;

		/// <inheritdoc />
		public  int NockSound => 75;

		/// <inheritdoc />
		public  int NockedID => 111;

		/// <summary>
		/// Initializes a new instance of the <see cref="Crossbow"/> class.
		/// </summary>
		public Crossbow()
		{
		}
	}
}
