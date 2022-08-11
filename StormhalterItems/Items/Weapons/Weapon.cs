using System;


namespace Kesmai.Server.Items
{
	public partial class Weapon 
	{
		public string WeaponName { get; set; } = string.Empty;
		public uint BasePrice { get; set; } = 30;

		/// <inheritdoc />
		public int MinimumDamage { get; set; } = 0;

		/// <inheritdoc />
		public int MaximumDamage { get; set; } = 8;

		/// <inheritdoc />
		public int BaseArmorBonus { get; set; } = 0;
		/// <inheritdoc />
		public int BaseAttackBonus { get; set; } = 0;


		/// <inheritdoc />
		public ShieldPenetration Penetration { get; set; } = ShieldPenetration.Light;


		/// <inheritdoc />
		public WeaponFlags Flags { get; set; } = WeaponFlags.BlueGlowing | WeaponFlags.Returning | WeaponFlags.Throwable
											 | WeaponFlags.Slashing | WeaponFlags.Lawful;

		/// <inheritdoc />
		public bool CanBind { get; set; } = false;
	}

	public enum WeaponFlags
	{
		Bashing,
		BlueGlowing,
		Bow,
		Chaotic,
		Crossbow,
		Lawful,
		MustThrow,
		Neutral,
		Piercing,
		QuickThrow,
		Returning,
		Silver,
		Slashing,
		Throwable,
		TwoHanded,
	}


	public enum Skill
	{
		Axe,
		Bow,
		Dagger,
		Crossbow,
		Flail,
		Greatsword,
		Halberd,
		Hand,
		Mace,
		Rapier,
		Sword,
		Shortsword,
		Staff,
		Throwing
	}
}