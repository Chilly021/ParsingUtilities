using System.Collections.Generic;
using System.IO;
using System.Drawing;



namespace Kesmai.Server.Items
{
	public partial class LeatherArmor : Armor
	{
		/// <inheritdoc />
		public  uint BasePrice => 25;

		/// <inheritdoc />
		public  int Weight => 1500;

		/// <inheritdoc />
		public  int Hindrance => 1;

		/// <inheritdoc />
		public  int SlashingProtection => 1;

		/// <inheritdoc />
		public  int BashingProtection => 1;
		
		/// <summary>
		/// Initializes a new instance of the <see cref="LeatherArmor"/> class.
		/// </summary>
		public LeatherArmor()
		{ }
	
	}
}
