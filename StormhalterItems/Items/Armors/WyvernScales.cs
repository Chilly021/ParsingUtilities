using System.Collections.Generic;
using System.IO;


namespace Kesmai.Server.Items
{
	public partial class WyvernScales : Armor
	{
		/// <inheritdoc />
		public  int LabelNumber => 6000096;

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
		/// Initializes a new instance of the <see cref="WyvernScales"/> class.
		/// </summary>
		public WyvernScales() 
		{
		}

		
	}
}