using System.Collections.Generic;
using System.IO;



namespace Kesmai.Server.Items
{
	public partial class SilverMoonStoneSword : Sword
	{
		
		/// <inheritdoc />
		/// <remarks>
		/// The individual components give 1700. If the item were to be broken by a player,
		/// it would award better experience.
		/// </remarks>
		public  uint BasePrice => 1000;

		/// <inheritdoc />
		public  int Weight => 4160;
		
		/// <inheritdoc />
		public  ShieldPenetration Penetration => ShieldPenetration.VeryHeavy;

		/// <inheritdoc />
		public  int MinimumDamage => 8;

		/// <inheritdoc />
		public  int MaximumDamage => 20;

		/// <inheritdoc />
		public  int BaseArmorBonus => 4;

		/// <inheritdoc />
		public  int BaseAttackBonus => 5;

		/// <inheritdoc />
		public  Skill Skill => Skill.Sword;

		/// <inheritdoc />
		public  WeaponFlags Flags => WeaponFlags.BlueGlowing | WeaponFlags.Silver | WeaponFlags.Slashing | WeaponFlags.Lawful;

        /// <inheritdoc />
		public  bool CanBind => true;

		/// <summary>
		/// Initializes a new instance of the <see cref="SilverMoonStoneSword"/> class.
		/// </summary>
		public SilverMoonStoneSword() : base(384)
		{
		}

        /// <summary>
		/// Initializes a new instance of the <see cref="SilverMoonStoneSword"/> class.
		/// </summary>
		public SilverMoonStoneSword(Serial serial) : base(serial)
		{
		}

		/// <inheritdoc />
		public  void GetDescription(List<LocalizationEntry> entries)
		{
			entries.Add(new LocalizationEntry(6200000, 6200378)); /* [You are looking at] [a sword that shimmers with the shine of the crecent moon.] */

			if (Identified)
				entries.Add(new LocalizationEntry(6300425)); /* The combat adds for this weapon are +5. */
		}
	}
}
