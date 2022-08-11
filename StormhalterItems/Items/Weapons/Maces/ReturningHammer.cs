using System.Collections.Generic;
using System.IO;



namespace Kesmai.Server.Items
{
	public partial class ReturningHammer : Mace
	{
		/// <inheritdoc />
		public  int LabelNumber => 6000047;

		/// <inheritdoc />
		public  uint BasePrice => 1;

		/// <inheritdoc />
		public  int Weight => 2000;

		/// <inheritdoc />
		public  int MinimumDamage => 1;

		/// <inheritdoc />
		public  int MaximumDamage => 8;

		/// <inheritdoc />
		public  int BaseArmorBonus => 2;

		/// <inheritdoc />
		public  int BaseAttackBonus => 3;

		/// <inheritdoc />
		public  Skill Skill => Skill.Mace;

		/// <inheritdoc />
		public  WeaponFlags Flags => WeaponFlags.BlueGlowing | WeaponFlags.Returning | WeaponFlags.Throwable
		                                     | WeaponFlags.Bashing | WeaponFlags.Lawful;

        /// <inheritdoc />
		public  bool CanBind => true;

		/// <summary>
		/// Initializes a new instance of the <see cref="ReturningHammer"/> class.
		/// </summary>
		public ReturningHammer() 
		{
		}
	}
}