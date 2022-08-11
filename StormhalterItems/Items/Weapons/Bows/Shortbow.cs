using System.Collections.Generic;
using System.IO;



namespace Kesmai.Server.Items
{
	public partial class Shortbow : Bow
	{
		/// <inheritdoc />
		public  int LabelNumber => 6000015;

		/// <inheritdoc />
		public  uint BasePrice => 20;

		/// <inheritdoc />
		public  int Weight => 600;

		/// <inheritdoc />
		public  ShieldPenetration Penetration => ShieldPenetration.Light;

		/// <inheritdoc />
		public  int MinimumDamage => 1;

		/// <inheritdoc />
		public  int MaximumDamage => 4;

		/// <inheritdoc />
		public  int NockedID => 99;
		
		/// <summary>
		/// Initializes a new instance of the <see cref="Shortbow"/> class.
		/// </summary>
		public Shortbow() 
		{
		}
	}
}