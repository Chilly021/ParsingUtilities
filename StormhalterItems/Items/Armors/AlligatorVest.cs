using System.Collections.Generic;
using System.IO;



namespace Kesmai.Server.Items
{
	public partial class AlligatorVest : Armor
	{
		/// <inheritdoc />
		public  int LabelNumber => 6000096; /* vest */

		/// <inheritdoc />
		public  uint BasePrice => 30;

		/// <inheritdoc />
		public  int Weight => 1500;

		/// <inheritdoc />
		public  int Hindrance => 1;

		/// <inheritdoc />
		public  int SlashingProtection => 1;

		/// <inheritdoc />
		public  int PiercingProtection => 1;

		/// <inheritdoc />
		public  int BashingProtection => 1;

		/// <summary>
		/// Initializes a new instance of the <see cref="AlligatorVest"/> class.
		/// </summary>
		public AlligatorVest() 
		{
		}
	
	}
}
