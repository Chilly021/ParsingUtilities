using System.Collections.Generic;
using System.IO;


namespace Kesmai.Server.Items
{
	public partial class PlatemailArmor : Armor
	{
		/// <inheritdoc />
		public  uint BasePrice => 100;

		/// <inheritdoc />
		public  int Weight => 4000;

		/// <inheritdoc />
		public  int Hindrance => 2;

		/// <inheritdoc />
		public  int SlashingProtection => 2;

		/// <inheritdoc />
		public  int PiercingProtection => 2;

		/// <inheritdoc />
		public  int BashingProtection => 2;

		/// <inheritdoc />
		public  int ProjectileProtection => 1;

		/// <inheritdoc />
		public  bool RestrictSpellcast => true;

		/// <summary>
		/// Initializes a new instance of the <see cref="PlatemailArmor"/> class.
		/// </summary>
		public PlatemailArmor() 
		{
		}

	
	}
}
