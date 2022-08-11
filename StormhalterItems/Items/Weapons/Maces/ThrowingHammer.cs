using System.Collections.Generic;
using System.IO;



namespace Kesmai.Server.Items
{
	public partial class ThrowingHammer : Mace
	{
		/// <inheritdoc />
		public  int LabelNumber => 6000047;

		/// <inheritdoc />
		public  uint BasePrice => 20;

		/// <inheritdoc />
		public  int Weight => 2000;

		/// <inheritdoc />
		public  int Category => 2;

		/// <inheritdoc />
		public  int MinimumDamage => 1;

		/// <inheritdoc />
		public  int MaximumDamage => 8;

		/// <inheritdoc />
		public  int BaseArmorBonus => 1;

		/// <inheritdoc />
		public  Skill Skill => Skill.Mace;

		/// <inheritdoc />
		public  WeaponFlags Flags => WeaponFlags.QuickThrow | WeaponFlags.Throwable | WeaponFlags.Bashing;
		
		/// <summary>
		/// Initializes a new instance of the <see cref="ThrowingHammer"/> class.
		/// </summary>
		public ThrowingHammer()
		{
		}


	}
}