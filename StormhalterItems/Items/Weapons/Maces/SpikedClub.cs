using System.Collections.Generic;
using System.IO;



namespace Kesmai.Server.Items
{
	public partial class SpikedClub : Mace
	{
		/// <inheritdoc />
		public  uint BasePrice => 20;

		/// <inheritdoc />
		public  int Weight => 4000;

		/// <inheritdoc />
		public  int MinimumDamage => 1;

		/// <inheritdoc />
		public  int MaximumDamage => 10;

		/// <inheritdoc />
		public  int BaseArmorBonus => 1;

				/// <inheritdoc />
		public  int BaseAttackBonus => 2;

		/// <inheritdoc />
		public  Skill Skill => Skill.Mace;

		/// <inheritdoc />
		public  WeaponFlags Flags => WeaponFlags.Bashing;
		
		/// <summary>
		/// Initializes a new instance of the <see cref="SpikedClub"/> class.
		/// </summary>
		public SpikedClub() 
		{
		}
	}
}