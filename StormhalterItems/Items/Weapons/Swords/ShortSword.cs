using System.Collections.Generic;
using System.IO;



namespace Kesmai.Server.Items
{
	public partial class ShortSword : Sword
	{
		/// <inheritdoc />
		public  uint BasePrice => 20;

		/// <inheritdoc />
		public  int Weight => 1200;

		/// <inheritdoc />
		public  ShieldPenetration Penetration => ShieldPenetration.Medium;

		/// <inheritdoc />
		public  int MinimumDamage => 1;

		/// <inheritdoc />
		public  int MaximumDamage => 6;
		
		/// <inheritdoc />
		public  WeaponFlags Flags => WeaponFlags.Piercing;
		
		/// <summary>
		/// Initializes a new instance of the <see cref="ShortSword"/> class.
		/// </summary>
		public ShortSword() 
		{
		}

	}
}