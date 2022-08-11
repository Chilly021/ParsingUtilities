using System.Collections.Generic;
using System.IO;



namespace Kesmai.Server.Items
{
	public partial class CopperHalberd : Halberd
	{
		/// <inheritdoc />
		public  uint BasePrice => 50;

		/// <inheritdoc />
		public  int Weight => 5000;

		/// <inheritdoc />
		public  int MinimumDamage => 2;

		/// <inheritdoc />
		public  int MaximumDamage => 14;

		/// <inheritdoc />
		public  int BaseArmorBonus => 2;

		/// <inheritdoc />
		public  int BaseAttackBonus => 5;
		
		/// <inheritdoc />
		public  WeaponFlags Flags => base.Flags | WeaponFlags.BlueGlowing | WeaponFlags.Lawful;

		/// <inheritdoc />
		public  bool CanBind => true;
		
		/// <summary>
		/// Initializes a new instance of the <see cref="CopperHalberd"/> class.
		/// </summary>
		public CopperHalberd() 
		{
		}
		
	
	}
}