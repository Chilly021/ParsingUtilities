using System.Collections.Generic;
using System.IO;



namespace Kesmai.Server.Items
{
	public partial class MisericordeDagger : Dagger
	{
		/// <inheritdoc />
		public  uint BasePrice => 30;

		/// <inheritdoc />
		public  ShieldPenetration Penetration => ShieldPenetration.Medium;

		/// <inheritdoc />
		public  int BaseArmorBonus => 2;

		/// <inheritdoc />
		public  int BaseAttackBonus => 4;

		/// <inheritdoc />
		public  int MinimumDamage => 1;

		/// <inheritdoc />
		public  int MaximumDamage => 8;

		/// <inheritdoc />
		public  WeaponFlags Flags => base.Flags | WeaponFlags.BlueGlowing | WeaponFlags.Neutral;

        /// <inheritdoc />
		public  bool CanBind => true;

        /// <inheritdoc />
		protected  int PoisonedItemId => 310;

		/// <summary>
		/// Initializes a new instance of the <see cref="MisericordeDagger"/> class.
		/// </summary>
		public MisericordeDagger() 
		{
		}

	}
}