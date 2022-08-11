using System.Collections.Generic;
using System.IO;



namespace Kesmai.Server.Items
{
	public partial class BlackBroadsword : Sword
	{
		/// <inheritdoc />
		public  int LabelNumber => 6000019;

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
		public  int MinimumDamage => 2;

		/// <inheritdoc />
		public  int MaximumDamage => 12;

		/// <inheritdoc />
		public  int BaseArmorBonus => 3;

		/// <inheritdoc />
		public  int BaseAttackBonus => 4;

		/// <inheritdoc />
		public  Skill Skill => Skill.Greatsword;

		/// <inheritdoc />
		public  WeaponFlags Flags => WeaponFlags.TwoHanded | WeaponFlags.BlueGlowing | WeaponFlags.Slashing | WeaponFlags.Lawful;

        /// <inheritdoc />
		public  bool CanBind => true;

		/// <summary>
		/// Initializes a new instance of the <see cref="BlackBroadsword"/> class.
		/// </summary>
		public BlackBroadsword() 
		{
		}
	}
}