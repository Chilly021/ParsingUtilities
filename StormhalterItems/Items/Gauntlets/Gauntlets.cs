using System;
using System.IO;





namespace Kesmai.Server.Items
{
	public abstract partial class Gauntlets : Weapon, IArmored
	{
		/// <inheritdoc />
		public int LabelNumber => 6000043;

		/// <inheritdoc />


		public Skill Skill => Skill.Hand;

		/// <inheritdoc />


		public virtual WeaponFlags Flags => WeaponFlags.Bashing;

		/// <inheritdoc />


		public virtual int BaseArmorBonus => 0;

		/// <inheritdoc />


		public virtual int BaseAttackBonus => 0;

		/// <inheritdoc />


		public virtual int SlashingProtection => 0;

		/// <inheritdoc />


		public virtual int PiercingProtection => 0;

		/// <inheritdoc />


		public virtual int BashingProtection => 0;

		/// <inheritdoc />


		public virtual int ProjectileProtection => 0;

		/// <inheritdoc />


		public virtual int MinimumDamage => 0;

		/// <inheritdoc />


		public virtual int MaximumDamage => 0;

		/// <inheritdoc />


		public virtual ShieldPenetration Penetration => ShieldPenetration.Light;

		/// <inheritdoc />
		public int Category => 8;

		/// <inheritdoc />
		public int AttackSound => 47;

		/// <inheritdoc />


		public int MaxRange => 0;

		/// <summary>
		/// Initializes a new instance of the <see cref="Gauntlets"/> class.
		/// </summary>
		protected Gauntlets()
		{
		}

		/// <inheritdoc />
		public int GetFumbleLocalization()
		{
			return 6300017; /* The gauntlets leap off your hands. */
		}

	}
}
