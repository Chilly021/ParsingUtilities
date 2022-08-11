using System.Collections.Generic;
using System.IO;


namespace Kesmai.Server.Items
{
	public partial class BearSkull : Helmet
	{
		/// <inheritdoc />
		public  int LabelNumber => 6000085;

		/// <inheritdoc />
		public  uint BasePrice => 2000;

		/// <inheritdoc />
		public  int Weight => 80;

		/// <inheritdoc />
		public  int ProtectionFromStun => 10;
		
		/// <inheritdoc />
		public  int ProtectionFromFire => 10;
		
		/// <inheritdoc />
		public  int ProtectionFromIce => 10;
		
		/// <inheritdoc />
		public  bool ProvidesNightVision => true;

		/// <summary>
		/// Initializes a new instance of the <see cref="BearSkull"/> class.
		/// </summary>
		public BearSkull() 
		{
		}
	}
}