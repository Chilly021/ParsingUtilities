using System.Collections.Generic;
using System.IO;



namespace Kesmai.Server.Items
{
	public partial class GiltDagger : Dagger
	{
		/// <inheritdoc />
		public  uint BasePrice => 500;

		/// <inheritdoc />
		public  int MinimumDamage => 3;

		/// <inheritdoc />
		public  int MaximumDamage => 7;

		/// <inheritdoc />
		public  int BaseArmorBonus => 1;

		/// <inheritdoc />
		public  int BaseAttackBonus => 3;
		
		/// <inheritdoc />
		protected  int PoisonedItemId => 312;

		/// <summary>
		/// Initializes a new instance of the <see cref="GiltDagger"/> class.
		/// </summary>
		public GiltDagger()
		{
		}
	}
}