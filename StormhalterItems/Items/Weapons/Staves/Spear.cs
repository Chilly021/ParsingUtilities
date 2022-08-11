using System.Collections.Generic;
using System.IO;



namespace Kesmai.Server.Items
{
	public partial class Spear : Staff
	{
		/// <inheritdoc />
		public  int LabelNumber => 6000086;

		/// <inheritdoc />
		public  uint BasePrice => 15;

		/// <inheritdoc />
		public  int Weight => 1400;

		/// <inheritdoc />
		public  int MinimumDamage => 1;

		/// <inheritdoc />
		public  int MaximumDamage => 8;

		/// <inheritdoc />
		public  int BaseArmorBonus => 2;

		/// <inheritdoc />
		public  WeaponFlags Flags => WeaponFlags.TwoHanded | WeaponFlags.Piercing;
		
		/// <summary>
		/// Initializes a new instance of the <see cref="Spear"/> class.
		/// </summary>
		public Spear() 
		{
		}
	}
}