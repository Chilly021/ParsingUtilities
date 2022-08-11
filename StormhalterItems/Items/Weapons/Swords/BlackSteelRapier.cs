using System.Collections.Generic;
using System.IO;


namespace Kesmai.Server.Items
{
	public partial class BlackSteelRapier : Rapier
	{
		/// <inheritdoc />
		public  uint BasePrice => 1;
		
		/// <inheritdoc />
		public  int BaseAttackBonus => 4;

		public  int BaseArmorBonus => 2;

		/// <inheritdoc />
		public  WeaponFlags Flags => base.Flags | WeaponFlags.BlueGlowing;

		/// <inheritdoc />
		public  bool CanBind => true;

		/// <summary>
		/// Initializes a new instance of the <see cref="BlackSteelRapier"/> class.
		/// </summary>
		public BlackSteelRapier() 
		{
		}


		
	}
}