using System.Collections.Generic;
using System.IO;


namespace Kesmai.Server.Items
{
	public partial class DrakeScaleArmor : Armor
	{
		/// <inheritdoc />
		public  int LabelNumber => 6000076; /* scales */

		/// <inheritdoc />
		public  uint BasePrice => 1600;

		/// <inheritdoc />
		public  int Weight => 1600;

		/// <inheritdoc />
		public  int Hindrance => 2;

		/// <inheritdoc />
		public  int SlashingProtection => 4;

		/// <inheritdoc />
		public  int PiercingProtection => 4;

		/// <inheritdoc />
		public  int BashingProtection => 4;

		/// <inheritdoc />
		public  int ProjectileProtection => 4;

		/// <inheritdoc />
		public  int ProtectionFromFire => 10;

		/// <inheritdoc />
		public  int ProtectionFromIce => 10;

		/// <summary>
		/// Initializes a new instance of the <see cref="DrakeScaleArmor"/> class.
		/// </summary>
		public DrakeScaleArmor() 
		{
		}
		
	}
}
