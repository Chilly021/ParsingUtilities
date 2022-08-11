using System.Collections.Generic;
using System.IO;



namespace Kesmai.Server.Items
{
	public partial class HeavyCrossbow : Crossbow
	{
		/// <inheritdoc />
		public  uint BasePrice => 60;

		/// <inheritdoc />
		public  int Weight => 1400;

		/// <inheritdoc />
		public  ShieldPenetration Penetration => ShieldPenetration.Heavy;

		/// <inheritdoc />
		public  int MinimumDamage => 2;

		/// <inheritdoc />
		public  int MaximumDamage => 12;

		/// <inheritdoc />
		public  int BaseAttackBonus => 4;
		
		/// <inheritdoc />
		public  WeaponFlags Flags => base.Flags | WeaponFlags.BlueGlowing;

		/// <inheritdoc />
		public  bool CanBind => true;
		
		/// <inheritdoc />
		public  int NockedID => 390;

		/// <summary>
		/// Initializes a new instance of the <see cref="HeavyCrossbow"/> class.
		/// </summary>
		public HeavyCrossbow() 
		{
		}
		
	}
}
