using System;
using System.Collections.Generic;
using System.IO;



namespace Kesmai.Server.Items
{
	public partial class HummingbirdSword : ShortSword
	{
		/// <inheritdoc />
		public  uint BasePrice => 2000;
		
		/// <inheritdoc />
		public  int BaseAttackBonus => 4;

		/// <inheritdoc />
		public  WeaponFlags Flags => base.Flags | WeaponFlags.BlueGlowing | WeaponFlags.Silver | WeaponFlags.Lawful;
		
		/// <inheritdoc />
		public  bool CanBind => true;
		
		/// <summary>
		/// Initializes a new instance of the <see cref="HummingbirdSword"/> class.
		/// </summary>
		public HummingbirdSword()
		{
		}

	}
}