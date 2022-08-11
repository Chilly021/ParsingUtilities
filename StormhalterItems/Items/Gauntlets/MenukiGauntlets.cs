using System.Collections.Generic;
using System.IO;



namespace Kesmai.Server.Items
{
	public partial class MenukiGauntlets : Gauntlets
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
		public  int MinimumDamage => 4;

        /// <inheritdoc />
		public  int MaximumDamage => 10;

        /// <inheritdoc />
		public  int BaseArmorBonus => 3;

        /// <inheritdoc />
		public  int BaseAttackBonus => 5;

        /// <inheritdoc />
		public  WeaponFlags Flags => base.Flags | WeaponFlags.BlueGlowing | WeaponFlags.Lawful | WeaponFlags.Silver;

        /// <inheritdoc />
		public  bool CanBind => true;

		/// <summary>
		/// Initializes a new instance of the <see cref="MenukiGauntlets"/> class.
		/// </summary>
		public MenukiGauntlets() : base(379)
		{
		}

        /// <summary>
		/// Initializes a new instance of the <see cref="MenukiGauntlets"/> class.
		/// </summary>
		public MenukiGauntlets(Serial serial) : base(serial)
		{
		}
		
        /// <inheritdoc />
		public  void GetDescription(List<LocalizationEntry> entries)
		{
			entries.Add(new LocalizationEntry(6200000, 6200380)); /* [You are looking at] [a pair of gauntlets made of iridescent green and blood red scales alternating in ever smaller pattern of glowing constellations. A wickedly curved talon projects from each knuckle.] */
		}
	}
}
