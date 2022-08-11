using System.Collections.Generic;
using System.IO;



namespace Kesmai.Server.Items
{
	public partial class Rapier : Sword
	{
		/// <inheritdoc />
		public  int LabelNumber => 6000071;

		/// <inheritdoc />
		public  uint BasePrice => 20;

		/// <inheritdoc />
		public  int Weight => 1150;

		/// <inheritdoc />
		public  ShieldPenetration Penetration => ShieldPenetration.Medium;

		/// <inheritdoc />
		public  int MinimumDamage => 1;

		/// <inheritdoc />
		public  int MaximumDamage => 10;

		/// <inheritdoc />
		public  int BaseArmorBonus => 1;

		/// <inheritdoc />
		public  Skill Skill => Skill.Rapier;

		/// <inheritdoc />
		public  WeaponFlags Flags => WeaponFlags.Piercing;
		
		/// <summary>
		/// Initializes a new instance of the <see cref="Rapier"/> class.
		/// </summary>
		public Rapier() 
		{
		}
	
	}
}