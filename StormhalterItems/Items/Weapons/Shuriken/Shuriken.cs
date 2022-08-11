using System.Collections.Generic;
using System.IO;



namespace Kesmai.Server.Items
{
	public partial class Shuriken : Weapon
	{
		/// <inheritdoc />
		public  int LabelNumber => 6000083;

		/// <inheritdoc />
		public  uint BasePrice => 20;

		/// <inheritdoc />
		public  int Weight => 150;

		/// <inheritdoc />
		public  int Category => 14;

		/// <inheritdoc />
		public  ShieldPenetration Penetration => ShieldPenetration.Light;

		/// <inheritdoc />
		public  int MinimumDamage => 1;

		/// <inheritdoc />
		public  int MaximumDamage => 4;

		/// <inheritdoc />
		public  Skill Skill => Skill.Throwing;

		/// <inheritdoc />
		public  WeaponFlags Flags => WeaponFlags.QuickThrow | WeaponFlags.Throwable | WeaponFlags.Piercing;

		/// <summary>
		/// Gets the item id for this weapon when poisoned.
		/// </summary>
		protected virtual int PoisonedItemId => 315;

		/// <summary>
		/// Initializes a new instance of the <see cref="Shuriken"/> class.
		/// </summary>
		public Shuriken() 
		{
		}


	}
}