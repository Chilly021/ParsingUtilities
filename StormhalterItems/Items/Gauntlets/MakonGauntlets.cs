using System.Collections.Generic;
using System.IO;



namespace Kesmai.Server.Items
{
	public partial class MakonGauntlets : Gauntlets
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
		public  int MinimumDamage => 8;

        /// <inheritdoc />
		public  int MaximumDamage => 16;

        /// <inheritdoc />
		public  int BaseArmorBonus => 4;

        /// <inheritdoc />
		public  int BaseAttackBonus => 6;

        /// <inheritdoc />
		public  WeaponFlags Flags => base.Flags | WeaponFlags.BlueGlowing | WeaponFlags.Lawful | WeaponFlags.Silver;

        /// <inheritdoc />
		public  bool CanBind => true;

		/// <summary>
		/// Initializes a new instance of the <see cref="MakonGauntlets"/> class.
		/// </summary>
		public MakonGauntlets() : base(380)
		{
		}
        
        /// <summary>
		/// Initializes a new instance of the <see cref="MakonGauntlets"/> class.
		/// </summary>
		public MakonGauntlets(Serial serial) : base(serial)
		{
		}

		/// <inheritdoc />
		public  bool CanEquip(MobileEntity entity)
		{
			if (entity is PlayerEntity { Profession: MartialArtist })
				return true;

			return false;
		}
		
        /// <inheritdoc />
		public  void GetDescription(List<LocalizationEntry> entries)
		{
			entries.Add(new LocalizationEntry(6200000, 6200381)); /* [You are looking at] [a pair of gauntlets with crystalline claws which have an odd metalic sheen. The long cuffs of thick leather are covered with thick green fur.] */
		}
	}
}
