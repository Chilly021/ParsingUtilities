using System.Collections.Generic;
using System.IO;


namespace Kesmai.Server.Items
{
	public partial class BlueStaff : Staff
	{
		/// <inheritdoc />
		public  uint BasePrice => 1500;

		/// <inheritdoc />
		public  int Weight => 500;

		/// <inheritdoc />
		public  int MinimumDamage => 1;

		/// <inheritdoc />
		public  int MaximumDamage => 8;

		/// <inheritdoc />
		public  int BaseArmorBonus => 2;

		/// <inheritdoc />
		public  WeaponFlags Flags => WeaponFlags.TwoHanded | WeaponFlags.Bashing;
		
		/// <summary>
		/// Initializes a new instance of the <see cref="BlueStaff"/> class.
		/// </summary>
		public BlueStaff() 
		{
		}

		
	}
}