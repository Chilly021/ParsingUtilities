using System.Collections.Generic;
using System.IO;



namespace Kesmai.Server.Items
{
	public partial class Longbow : Bow
	{
		/// <inheritdoc />
		public  int LabelNumber => 6000058;

		/// <inheritdoc />
		public  uint BasePrice => 30;

		/// <inheritdoc />
		public  int Weight => 800;

		/// <inheritdoc />
		public  int Category => 1;

		/// <inheritdoc />
		public  ShieldPenetration Penetration => ShieldPenetration.Light;

		/// <inheritdoc />
		public  int MinimumDamage => 1;

		/// <inheritdoc />
		public  int MaximumDamage => 6;

		/// <inheritdoc />
		public  int NockedID => 113;

		/// <summary>
		/// Initializes a new instance of the <see cref="Longbow"/> class.
		/// </summary>
		public Longbow() 
		{
		}
	}
}
