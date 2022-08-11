using System.Collections.Generic;
using System.IO;


namespace Kesmai.Server.Items
{
	public partial class PlatemailGauntlets : Gauntlets
	{
		/// <inheritdoc />
		public  int LabelNumber => 6000041;

		/// <inheritdoc />
		public  uint BasePrice => 100;

		/// <inheritdoc />
		public  int Weight => 200;

		/// <inheritdoc />
		public  int MinimumDamage => 1;

		/// <inheritdoc />
		public  int MaximumDamage => 4;

		/// <summary>
		/// Initializes a new instance of the <see cref="PlatemailGauntlets"/> class.
		/// </summary>
		public PlatemailGauntlets() 
		{
		}
	}
}