using System.Collections.Generic;
using System.IO;


namespace Kesmai.Server.Items
{
	public partial class ChainmailArmor : Armor
	{
		/// <inheritdoc />
		public  uint BasePrice => 50;

		/// <inheritdoc />
		public  int Weight => 2800;

		/// <inheritdoc />
		public  int Hindrance => 1;
		
		/// <inheritdoc />
		public  int SlashingProtection => 2;

		/// <inheritdoc />
		public  int PiercingProtection => 1;

		/// <inheritdoc />
		public  int BashingProtection => 1;
		
		/// <inheritdoc />
		public  bool RestrictSpellcast => true;

		/// <summary>
		/// Initializes a new instance of the <see cref="ChainmailArmor"/> class.
		/// </summary>
		public ChainmailArmor() 
		{
		}


	}
}
