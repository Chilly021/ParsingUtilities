using System.Collections.Generic;
using System.IO;



namespace Kesmai.Server.Items
{
	public partial class IronRodChaotic : Staff
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
		public  int MaximumDamage => 6;

		/// <inheritdoc />
		public  int BaseArmorBonus => 1;

		/// <inheritdoc />
		public  int BaseAttackBonus => 3;

		/// <inheritdoc />
		public  WeaponFlags Flags => WeaponFlags.TwoHanded | WeaponFlags.Bashing | WeaponFlags.Chaotic;
		
		/// <summary>
		/// Initializes a new instance of the <see cref="IronRodChaotic"/> class.
		/// </summary>
		public IronRodChaotic() 
		{
		}

	
	}
}