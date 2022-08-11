using System.Collections.Generic;
using System.IO;



namespace Kesmai.Server.Items
{
	public partial class BayonetHammer : Mace
	{
		/// <inheritdoc />
		public  int LabelNumber => 6000047;

		/// <inheritdoc />
		public  uint BasePrice => 30;

		/// <inheritdoc />
		public  int Weight => 2000;

		/// <inheritdoc />
		public  int MinimumDamage => 1;

		/// <inheritdoc />
		public  int MaximumDamage => 10;

		/// <inheritdoc />
		public  int BaseArmorBonus => 1;

		/// <inheritdoc />
		public  Skill Skill => Skill.Mace;

		/// <inheritdoc />
		public  WeaponFlags Flags => WeaponFlags.Throwable | WeaponFlags.Slashing | WeaponFlags.Bashing;
		
		/// <summary>
		/// Initializes a new instance of the <see cref="BayonetHammer"/> class.
		/// </summary>
		public BayonetHammer() 
		{
		}
	}
}
