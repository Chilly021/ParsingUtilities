using System.Collections.Generic;
using System.IO;


namespace Kesmai.Server.Items
{
	public partial class SaffronRobe : Robe
	{
		/// <inheritdoc />
		public  uint BasePrice => 2400;

		/// <inheritdoc />
		public  int Weight => 1600;

		/// <inheritdoc />
		/// <remarks>Robes have a default <see cref="Hindrance"/> value of 1.</remarks>
		public  int Hindrance => 0;

		/// <inheritdoc />
		public  int ProtectionFromFire => 5;

		/// <inheritdoc />
		public  int ProtectionFromIce => 5;

		/// <inheritdoc />
		public  int ManaRegeneration => 1;

		/// <summary>
		/// Initializes a new instance of the <see cref="SaffronRobe"/> class.
		/// </summary>
		public SaffronRobe() 
		{
		}

		
	}
}