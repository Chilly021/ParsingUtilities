using System.Collections.Generic;
using System.IO;


namespace Kesmai.Server.Items
{
	public partial class IceDragonScaleArmor : Armor
	{
		/// <inheritdoc />
		public  int LabelNumber => 6000076; /* scales */

		/// <inheritdoc />
		public  uint BasePrice => 3200;

		/// <inheritdoc />
		public  int Weight => 1600;

		/// <inheritdoc />
		public  int Hindrance => 2;

		/// <inheritdoc />
		public  int SlashingProtection => 5;

		/// <inheritdoc />
		public  int PiercingProtection => 5;

		/// <inheritdoc />
		public  int BashingProtection => 5;

		/// <inheritdoc />
		public  int ProjectileProtection => 5;


		/// <inheritdoc />
		public  int ProtectionFromConcussion => 30;
		
		/// <inheritdoc />
		public  int ProtectionFromFire => 15;

		/// <inheritdoc />
		public  int ProtectionFromIce => 15;

		/// <summary>
		/// Initializes a new instance of the <see cref="IceDragonScaleArmor"/> class.
		/// </summary>
		public IceDragonScaleArmor() 
		{
		}
		
	}
}
