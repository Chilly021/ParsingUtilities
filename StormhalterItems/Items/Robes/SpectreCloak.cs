using System.Collections.Generic;
using System.Drawing;
using System.IO;


namespace Kesmai.Server.Items
{
	public partial class SpectreCloak : Robe
	{
		/// <inheritdoc />
		public  int LabelNumber => 6000026;
		
		/// <inheritdoc />
		public  uint BasePrice => 2400;

		/// <inheritdoc />
		public  int Weight => 1000;

		/// <inheritdoc />
		/// <remarks>Robes have a default <see cref="Hindrance"/> value of 1.</remarks>
		public  int Hindrance => 0;

		/// <summary>
		/// Initializes a new instance of the <see cref="SpectreCloak"/> class.
		/// </summary>
		public SpectreCloak()
		{ }

	}
}