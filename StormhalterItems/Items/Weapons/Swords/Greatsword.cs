using System.Collections.Generic;
using System.IO;



namespace Kesmai.Server.Items
{
	public partial class Greatsword : Sword
	{
		/// <inheritdoc />
		public  int LabelNumber => 6000045;

		/// <inheritdoc />
		public  uint BasePrice => 40;

		/// <inheritdoc />
		public  int Weight => 4350;

		/// <inheritdoc />
		public  int Category => 1;

		/// <inheritdoc />
		public  int MinimumDamage => 2;

		/// <inheritdoc />
		public  int MaximumDamage => 10;

		/// <inheritdoc />
		public  int BaseArmorBonus => 1;

		/// <inheritdoc />
		public  Skill Skill => Skill.Greatsword;

		/// <inheritdoc />
		public  WeaponFlags Flags => WeaponFlags.TwoHanded | WeaponFlags.Slashing;
		
		/// <summary>
		/// Initializes a new instance of the <see cref="Greatsword"/> class.
		/// </summary>
		public Greatsword() 
		{
		}


	}
}