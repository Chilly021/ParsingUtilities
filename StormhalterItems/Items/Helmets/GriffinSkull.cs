using System.Collections.Generic;
using System.IO;


namespace Kesmai.Server.Items
{
	public partial class GriffinSkull : Helmet
	{
		/// <inheritdoc />
		public  int LabelNumber => 6000085;

		/// <inheritdoc />
		public  uint BasePrice => 3000;

		/// <inheritdoc />
		public  int Weight => 80;
		
		/// <inheritdoc />
		public  int ProtectionFromStun => 10;
		
		/// <inheritdoc />
		public  int ProtectionFromFire => 15;
		
		/// <inheritdoc />
		public  int ProtectionFromIce => 15;
		
		/// <inheritdoc />
		public  bool ProvidesNightVision => true;

		/// <summary>
		/// Initializes a new instance of the <see cref="GriffinSkull"/> class.
		/// </summary>
		public GriffinSkull() 
		{
		}
	}
}