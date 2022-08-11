using System.Collections.Generic;
using System.IO;



namespace Kesmai.Server.Items
{
	public partial class Katana : Sword
	{
		/// <inheritdoc />
		public  int LabelNumber => 6000054;

		/// <inheritdoc />
		public  uint BasePrice => 30;

		/// <inheritdoc />
		public  int Weight => 1450;

		/// <inheritdoc />
		public  int MinimumDamage => 1;

		/// <inheritdoc />
		public  int MaximumDamage => 8;

		/// <inheritdoc />
		public  int BaseArmorBonus => 1;

		/// <inheritdoc />
		public  Skill Skill => Skill.Sword;

		/// <inheritdoc />
		public  WeaponFlags Flags => WeaponFlags.Slashing;
		
		/// <summary>
		/// Initializes a new instance of the <see cref="Katana"/> class.
		/// </summary>
		public Katana() 
		{
		}

	}
}