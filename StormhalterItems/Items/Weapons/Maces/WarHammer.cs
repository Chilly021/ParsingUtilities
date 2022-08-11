using System.Collections.Generic;
using System.IO;



namespace Kesmai.Server.Items
{
	public partial class WarHammer : Mace
	{
		/// <inheritdoc />
		public  int LabelNumber => 6000047;

		/// <inheritdoc />
		public  uint BasePrice => 20;

		/// <inheritdoc />
		public  int Weight => 2000;

		/// <inheritdoc />
		public  int MinimumDamage => 4;

		/// <inheritdoc />
		public  int MaximumDamage => 12;

		/// <inheritdoc />
		public  int BaseArmorBonus => 1;

		/// <inheritdoc />
		public  Skill Skill => Skill.Mace;

		/// <inheritdoc />
		public  WeaponFlags Flags => WeaponFlags.Throwable | WeaponFlags.Bashing;
		
		/// <summary>
		/// Initializes a new instance of the <see cref="WarHammer"/> class.
		/// </summary>
		public WarHammer() 
		{
		}
		
		
	}
}