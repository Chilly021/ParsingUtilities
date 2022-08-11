using System.Collections.Generic;
using System.IO;



namespace Kesmai.Server.Items
{
	public partial class YasnakiDagger : Dagger
	{
		/// <inheritdoc />
		public  uint BasePrice => 1;

		/// <inheritdoc />
		public  int BaseAttackBonus => 5;

			/// <inheritdoc />
		public  int MinimumDamage => 4;

		/// <inheritdoc />
		public  int MaximumDamage => 10;

		/// <inheritdoc />
		public  WeaponFlags Flags => base.Flags | WeaponFlags.Silver | WeaponFlags.Returning;

		/// <inheritdoc />
		public  bool CanBind => true;

		/// <inheritdoc />
		protected  int PoisonedItemId => 314;

		/// <summary>
		/// Initializes a new instance of the <see cref="YasnakiDagger"/> class.
		/// </summary>
		public YasnakiDagger() 
		{
		}
	}
}