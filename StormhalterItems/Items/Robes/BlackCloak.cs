using System.Collections.Generic;
using System.IO;


namespace Kesmai.Server.Items
{
	public partial class BlackCloak : Robe
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

		/// <inheritdoc />
		public  int ManaRegeneration => 1;

		/// <summary>
		/// Initializes a new instance of the <see cref="BlackCloak"/> class.
		/// </summary>
		public BlackCloak()
		{
		}

	}
}