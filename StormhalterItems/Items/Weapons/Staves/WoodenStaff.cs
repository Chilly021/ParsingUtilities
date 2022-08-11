using System.Collections.Generic;
using System.IO;



namespace Kesmai.Server.Items
{
	public partial class WoodenStaff : Staff
	{
		/// <inheritdoc />
		public  uint BasePrice => 15;

		/// <inheritdoc />
		public  int Weight => 1400;

		/// <inheritdoc />
		public  int MinimumDamage => 1;

		/// <inheritdoc />
		public  int MaximumDamage => 8;

		/// <inheritdoc />
		public  int BaseArmorBonus => 2;

		/// <inheritdoc />
		public  WeaponFlags Flags => WeaponFlags.TwoHanded | WeaponFlags.Bashing;
		
		/// <summary>
		/// Initializes a new instance of the <see cref="WoodenStaff"/> class.
		/// </summary>
		public WoodenStaff() 
		{
		}
		
	}
}