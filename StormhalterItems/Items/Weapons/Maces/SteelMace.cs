using System.Collections.Generic;
using System.IO;



namespace Kesmai.Server.Items
{
	public partial class SteelMace : Mace
	{
		/// <inheritdoc />
		public  uint BasePrice => 25;

		/// <inheritdoc />
		public  int Weight => 1800;

		/// <inheritdoc />
		public  ShieldPenetration Penetration => ShieldPenetration.Medium;

		/// <inheritdoc />
		public  int MinimumDamage => 1;

		/// <inheritdoc />
		public  int MaximumDamage => 6;

		/// <inheritdoc />
		public  int BaseArmorBonus => 1;

		/// <inheritdoc />
		public  Skill Skill => Skill.Mace;

		/// <inheritdoc />
		public  WeaponFlags Flags => WeaponFlags.Bashing;
		
		/// <summary>
		/// Initializes a new instance of the <see cref="SteelMace"/> class.
		/// </summary>
		public SteelMace() 
		{
		}
		
	
	}
}