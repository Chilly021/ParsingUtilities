using System.Collections.Generic;
using System.IO;



namespace Kesmai.Server.Items
{
	public partial class Javelin : Staff
	{
		/// <inheritdoc />
		public  int LabelNumber => 6000053;

		/// <inheritdoc />
		public  uint BasePrice => 20;

		/// <inheritdoc />
		public  int Weight => 1400;

		/// <inheritdoc />
		public  int Category => 2;

		/// <inheritdoc />
		public  int MinimumDamage => 1;

		/// <inheritdoc />
		public  int MaximumDamage => 8;

		/// <inheritdoc />
		public  WeaponFlags Flags => WeaponFlags.TwoHanded | WeaponFlags.MustThrow | WeaponFlags.Throwable | WeaponFlags.Piercing;
		

	}
}