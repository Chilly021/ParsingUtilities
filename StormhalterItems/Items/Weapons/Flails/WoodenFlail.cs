using System.Collections.Generic;
using System.IO;



namespace Kesmai.Server.Items
{
	public partial class WoodenFlail : Flail
	{
		/// <inheritdoc />
		public  uint BasePrice => 25;

		/// <inheritdoc />
		public  int Weight => 1800;
		
		/// <inheritdoc />
		public  int MinimumDamage => 1;

		/// <inheritdoc />
		public  int MaximumDamage => 10;

		/// <inheritdoc />
		public  int BaseArmorBonus => 1;

		/// <summary>
		/// Initializes a new instance of the <see cref="WoodenFlail"/> class.
		/// </summary>
		public WoodenFlail()
		{ }


	}
}