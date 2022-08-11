using System.Collections.Generic;
using System.IO;



namespace Kesmai.Server.Items
{
	public partial class IronRod : Staff
	{
		/// <inheritdoc />
		public  uint BasePrice => 25;

		/// <inheritdoc />
		public  int Weight => 4500;

		/// <inheritdoc />
		public  ShieldPenetration Penetration => ShieldPenetration.Medium;

		/// <inheritdoc />
		public  int MinimumDamage => 1;

		/// <inheritdoc />
		public  int MaximumDamage => 8;

		/// <inheritdoc />
		public  int BaseArmorBonus => 2;

		/// <inheritdoc />
		public  int BaseAttackBonus => 4;

		/// <inheritdoc />
		public  WeaponFlags Flags => WeaponFlags.TwoHanded | WeaponFlags.Bashing | WeaponFlags.Lawful;
		
		/// <summary>
		/// Initializes a new instance of the <see cref="IronRod"/> class.
		/// </summary>
		public IronRod() 
		{
		}

	}
}