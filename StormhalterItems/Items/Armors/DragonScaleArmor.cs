using System.Collections.Generic;
using System.IO;


namespace Kesmai.Server.Items
{
	public partial class DragonScaleArmor : Armor
	{
		/// <inheritdoc />
		public  int LabelNumber => 6000076; /* scales */

		/// <inheritdoc />
		public  uint BasePrice => 800;

		/// <inheritdoc />
		public  int Weight => 3000;

		/// <inheritdoc />
		public  int Hindrance => 2;

		/// <inheritdoc />
		public  int SlashingProtection => 3;

		/// <inheritdoc />
		public  int PiercingProtection => 3;

		/// <inheritdoc />
		public  int BashingProtection => 3;

		/// <inheritdoc />
		public  int ProjectileProtection => 3;

		/// <inheritdoc />
		public  int ProtectionFromFire => 5;

		/// <inheritdoc />
		public  int ProtectionFromIce => 5;

		/// <summary>
		/// Initializes a new instance of the <see cref="DragonScaleArmor"/> class.
		/// </summary>
		public DragonScaleArmor() 
		{
		}
		
	}
}
