using System.Collections.Generic;
using System.IO;


namespace Kesmai.Server.Items
{
	public partial class LeatherGauntlets : Gauntlets
	{
		/// <inheritdoc />
		public  int LabelNumber => 6000041;

		/// <inheritdoc />
		public  uint BasePrice => 200;

		/// <inheritdoc />
		public  int Weight => 200;

		/// <inheritdoc />
		public  int MinimumDamage => 1;

		/// <inheritdoc />
		public  int MaximumDamage => 4;

		/// <inheritdoc />
		public  int BaseAttackBonus => 1;

		/// <summary>
		/// Initializes a new instance of the <see cref="LeatherGauntlets"/> class.
		/// </summary>
		public LeatherGauntlets() 
		{
		}


	}
}