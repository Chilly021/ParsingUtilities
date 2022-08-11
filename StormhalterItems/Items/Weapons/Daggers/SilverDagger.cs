using System.Collections.Generic;
using System.IO;



namespace Kesmai.Server.Items
{
	public partial class SilverDagger : Dagger
	{
		/// <inheritdoc />
		public  uint BasePrice => 350;

		/// <inheritdoc />
		public  int BaseAttackBonus => 2;

		/// <inheritdoc />
		public  WeaponFlags Flags => base.Flags | WeaponFlags.Silver;

		/// <inheritdoc />
		protected  int PoisonedItemId => 311;

		/// <summary>
		/// Initializes a new instance of the <see cref="SilverDagger"/> class.
		/// </summary>
		public SilverDagger()
		{
		}

	}
}